using MicroHelper.CQRS.Event.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event
{
    internal sealed class EventPublisher : IEventPublisher
    {
        private readonly IServiceScopeFactory serviceFactory;

        public EventPublisher(IServiceScopeFactory serviceFactory)
        {
            this.serviceFactory = serviceFactory;
        }
        public async Task PublishAsync<T>(T @event) where T : class, IEvent
        {
            using var scope = serviceFactory.CreateScope();
            var handlers = scope.ServiceProvider.GetServices<IEventHandler<T>>();
            foreach (var handler in handlers)
                await handler.HandleAsync(@event);
        }
    }
}
