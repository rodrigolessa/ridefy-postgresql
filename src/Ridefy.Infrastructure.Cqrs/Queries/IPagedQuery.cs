using Ridefy.Infrastructure.Cqrs.Queries.Specifications;

namespace Ridefy.Infrastructure.Cqrs.Queries;

public interface IPagedQuery<T> where T : class
{
    ISpecification<T> Specification { get; set; }
    int PageSize { get; set; }
    int PageNumber { get; set; }
}