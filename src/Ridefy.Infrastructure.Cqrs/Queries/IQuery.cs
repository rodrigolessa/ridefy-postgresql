using MediatR;

namespace Ridefy.Infrastructure.Cqrs.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
    
}