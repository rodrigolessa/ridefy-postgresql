namespace Ridefy.Infrastructure.Cqrs.Commands;

public interface IBaseCommand
{
    string AggregateId { get; set; }
    string IdempotencyKey { get; set; }
    string SessionKey { get; set; }
    string RouteKey { get; set; }
    string? ApplicationKey { get; set; }
    string? UserEmail { get; set; }
    DateTime Timestamp { get; set; }
}