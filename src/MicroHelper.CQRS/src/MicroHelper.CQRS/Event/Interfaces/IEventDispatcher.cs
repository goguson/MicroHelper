using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IEventDispatcher
    {
        Task DisptachAsync<T>(T @event) where T : class, IEvent;
    }
}
