namespace MicroHelper.CQRS.Event.Interfaces
{
    public interface IRejectedEvent : IEvent
    {
        string Reason { get; }
        string Code { get; }
    }
}
