using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IEventDispatcher
    {
        Task DispatchAsync<T>(T @event) where T : class, IEvent;
    }
}
