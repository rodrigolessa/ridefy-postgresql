using MediatR;

namespace Ridefy.Infrastructure.Cqrs.RequestProcessor;

public interface IRequestProcessor
{
    Task<TResponse> Process<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default)
        where TRequest : IRequest<TResponse>;
}