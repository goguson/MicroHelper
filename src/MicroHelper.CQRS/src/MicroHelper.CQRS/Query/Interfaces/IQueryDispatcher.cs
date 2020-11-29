using System.Threading.Tasks;

namespace MicroHelper.CQRS.Query.Interfaces
{
    public interface IQueryDispatcher
    {
        public Task<TResult> QueryAsync<TQuery, TResult>(TQuery query) where TQuery : class, IQuery<TResult>;
    }
}
