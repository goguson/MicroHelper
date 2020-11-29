namespace MicroHelper.CQRS.Query.Interfaces
{
    public interface IPagedQuery : IQuery
    {
        int Results { get; }
        int Page { get; }
        string OrderBy { get; }
        string SortOrder { get; }
    }
    public interface IPagedQuery<T> : IQuery<T>
    {
        int Results { get; }
        int Page { get; }
        string OrderBy { get; }
        string SortOrder { get; }
    }
}
