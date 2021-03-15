using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using EventBus.Events;
using EventBus.Interfaces;
using Infrastructure.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Application.Abstractions
{
    public abstract class BaseEventHandler<IEvent> : IIntegrationEventHandler<IEvent> where IEvent : IntegrationEvent
    {
        protected readonly ILogger<IIntegrationEventHandler<IEvent>> Logger;
        protected readonly IMapper Mapper;
        protected readonly IDbContext DbContext;
        protected List<IntegrationEvent> eventsToPublish = new List<IntegrationEvent>();
        protected IMediator Mediator;
        protected readonly string AppName = Assembly.GetCallingAssembly().FullName;

        public BaseEventHandler(ICoreAggregator coreAggregator)
        {
            Logger = coreAggregator.Logger.CreateLogger<IIntegrationEventHandler<IEvent>>();
            DbContext = coreAggregator.DbContext ?? throw new ArgumentNullException(nameof(coreAggregator.DbContext));
            Mapper = coreAggregator.Mapper ?? throw new ArgumentNullException(nameof(coreAggregator.Mapper));
            Mediator = coreAggregator.Mediator ?? throw new ArgumentNullException(nameof(coreAggregator.Mediator));
        }

        public List<IntegrationEvent> GetPublishedEvents()
        {
            return eventsToPublish;
        }

        public async Task PublishNewIntegrationEvents()
        {
            foreach (var eventToPublish in eventsToPublish)
            {
                try
                {
                    Logger.LogInformation($"Publishing integration event {eventToPublish}");
                    await Mediator.Publish(eventToPublish);
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, $"----- Error during publishing of new integration event: {eventToPublish.ToString()} {ex.Message}");
                }
            }
        }

        public async Task<bool> Handle(IEvent @event)
        {
            try
            {
                Logger.LogInformation(
                    $"----- Handling integration event: {@event.Id} at: Dispatch Service - {@event}");
                await HandleEx(@event);
                DbContext.Commit();
                Task.Run(() => PublishNewIntegrationEvents());
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, $"----- Error during integration event: {ex.Message}", "");
                DbContext.Rollback();
            }
            return true;
        }

        public abstract Task HandleEx(IEvent @event);


    }
}