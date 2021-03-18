using Autofac;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Infrastructure.Interfaces;
using Autofac.Extensions.DependencyInjection;
using System;
using MediatR;
using Application.Abstractions;
using System.Reflection;
using MediatR.Pipeline;
using Application.Interfaces;
using System.Linq;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using Infrastructure.Events;
using Autofac.Extras.AggregateService;
using Infrastructure.CacheImplementations;
using Infrastructure.CacheInterfaces;

namespace Mega.Drive
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IDbContext, MainDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RACE API", Version = "v1" });
            });
            services.AddControllers();           
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<Mediator>()
                .As<IMediator>().PropertiesAutowired().InstancePerLifetimeScope();

            // request & notification handlers
            builder.Register<ServiceFactory>(context =>
            {
                var c = context.Resolve<IComponentContext>();
                return t => c.Resolve(t);
            });

            builder.RegisterAssemblyTypes(typeof(BaseHandler<,>).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>)).PropertiesAutowired().InstancePerDependency();

            builder.RegisterGeneric(typeof(EventBusPublisher<>)).As(typeof(INotificationHandler<>));
            builder.RegisterAutoMapper(typeof(Domain.AutoMapper.AutoMapperProfile).GetTypeInfo().Assembly);

            builder.RegisterType(typeof(RuntimeCache)).As<ICache>().SingleInstance(); 

            builder.RegisterAggregateService<ICoreAggregator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mega.Drive v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}