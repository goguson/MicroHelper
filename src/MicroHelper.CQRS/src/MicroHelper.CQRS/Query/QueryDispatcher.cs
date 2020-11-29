using MicroHelper.CQRS.Query.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;


namespace MicroHelper.CQRS.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceScopeFactory serviceFactory;

        public QueryDispatcher(IServiceScopeFactory serviceFactory)
        {
            this.serviceFactory = serviceFactory;
        }
        public async Task<TResult> QueryAsync<TQuery, TResult>(TQuery query) where TQuery : class, IQuery<TResult>
        {
            using var scope = serviceFactory.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService<IQueryHandler<TQuery, TResult>>();
            return await handler.HandleAsync(query);
        }
    }
}
