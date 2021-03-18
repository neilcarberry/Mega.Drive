using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain.Models;
using Infrastructure.CacheInterfaces;
using Infrastructure.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Abstractions
{
    public abstract class BaseHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : BaseRequest<TResponse>
    {
        public bool UseCache { get; set; } = true;
        protected ILogger<TRequest> Logger { get; private set; }
        protected IMediator Mediator { get; private set; }
        protected IDbContext DbContext { get; private set; }
        protected IMapper Mapper { get; private set; }
        protected ICache Cache { get; private set; }
        public ICoreAggregator CoreAggregator
        {
            set
            {
                Logger = value.Logger.CreateLogger<TRequest>();
                Mediator = value.Mediator;
                DbContext = value.DbContext;
                Mapper = value.Mapper;
                Cache = value.Cache;
            }
        }
        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            try
            {
                Logger.LogInformation($"----- Handling command: {request}");
                TResponse result = default;
                
                if (UseCache)
                {
                    result = Cache.Get<TResponse>(request.CacheKey);
                }
                
                if (result == null)
                {
                    result = await HandleEx(request, cancellationToken);
                }
                
                if(result!=null)
                {
                    Cache.Add(request.CacheKey, result, request.CacheTime);
                }

                DbContext.Commit();
                return result;
            }
            catch (BaseHttpException bex)
            {
                DbContext.Rollback();
                throw new Exception($"Error in {typeof(TRequest)}", bex );
            }
            catch (Exception ex)
            {
                Logger.LogInformation($"----- Error during command: {ex.Message}");
                DbContext.Rollback();
                return default;
            }
        }

        public abstract Task<TResponse> HandleEx(TRequest request, CancellationToken cancellationToken);

    }
}