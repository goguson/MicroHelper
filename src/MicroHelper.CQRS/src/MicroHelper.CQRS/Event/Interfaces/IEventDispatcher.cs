using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IEventDispatcher
    {
        async Task DisptachAsync<T>(T @event) where T : class, IEvent;
    }
}
