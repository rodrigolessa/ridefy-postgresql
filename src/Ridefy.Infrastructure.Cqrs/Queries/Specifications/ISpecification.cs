using System.Linq.Expressions;
using MediatR;

namespace Ridefy.Infrastructure.Cqrs.Queries.Specifications;

public interface ISpecification<T> : IQuery<IEnumerable<T>>, IRequest where T : class
{
    Expression<Func<T, bool>> SatisfiedBy();
}