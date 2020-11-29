using System.Threading.Tasks;

namespace MicroHelper.CQRS.Command.Interfaces
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command) where T : class, ICommand;
    }
}
