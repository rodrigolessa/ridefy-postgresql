using System.Collections;

namespace Ridefy.Infrastructure.Cqrs.Queries.Results;

public interface IPagedResult
{
    IEnumerable GetRecords();
    PagedResultDetails GetPagination();
}