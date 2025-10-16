using Ridefy.Infrastructure.Cqrs.Queries.Results;
using Ridefy.Infrastructure.Cqrs.Queries.Specifications;

namespace Ridefy.Infrastructure.Cqrs.Queries;

public class PagedQuery<T> : IPagedQuery<T>, IQuery<PagedResult<T>> where T : class
{
    public ISpecification<T> Specification { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}