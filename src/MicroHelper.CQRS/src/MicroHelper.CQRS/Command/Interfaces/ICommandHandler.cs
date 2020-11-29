using System.Threading.Tasks;

namespace MicroHelper.CQRS.Command.Interfaces
{
    public interface ICommandHandler<in T> where T : class, ICommand
    {
        Task HandleAsync(T command);
    }
}
