using MicroHelper.CQRS.Event.Interfaces;

namespace MicroHelper.CQRS.Event
{
    public class RejectedEvent : IRejectedEvent
    {
        public string Reason { get; set; }
        public string Code { get; set; }
        public RejectedEvent(string reason, string code)
        {
            Reason = reason;
            Code = code;
        }
    }
}
