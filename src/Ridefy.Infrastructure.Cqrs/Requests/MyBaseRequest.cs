using MediatR;

namespace Ridefy.Infrastructure.Cqrs.Requests;

public class MyBaseRequest<TResponse> : IRequest<TResponse>
{
    public string? ClientApplication { get; set; }
    public string? UserEmail { get; set; }
    public string? IdempotencyKey { get; set; }
    public string? SagaProcessKey { get; set; }
}