using MediatR;

namespace Ridefy.Infrastructure.Cqrs.RequestProcessor;

public interface ICommandRequest<out TResponse> : IRequest<TResponse>
{
}