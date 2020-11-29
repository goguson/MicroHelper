using MicroHelper.CQRS.Event.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event
{
    internal sealed class EventDispatcher : IEventDispatcher
    {
        private readonly IServiceScopeFactory serviceFactory;

        public EventDispatcher(IServiceScopeFactory serviceFactory)
        {
            this.serviceFactory = serviceFactory;
        }
        public async Task DispatchAsync<T>(T @event) where T : class, IEvent
        {
            using var scope = serviceFactory.CreateScope();
            var handlers = scope.ServiceProvider.GetServices<IEventHandler<T>>();
            foreach (var handler in handlers)
                await handler.HandleAsync(@event);
        }
    }
}
