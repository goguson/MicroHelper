using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IEventHandler<in T> where T : class, IEvent
    {
        Task HandleAsync(T @event);
    }
}
