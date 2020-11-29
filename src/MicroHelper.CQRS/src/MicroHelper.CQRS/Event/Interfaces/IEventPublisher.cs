using System.Threading.Tasks;

namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IEventPublisher
    {
        Task PublishAsync<T>(T @event) where T : class, IEvent;
    }
}
