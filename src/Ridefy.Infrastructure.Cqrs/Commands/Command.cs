using MediatR;

namespace Ridefy.Infrastructure.Cqrs.Commands;

public abstract class Command(
    string aggregateId,
    string? idempotencyKey,
    string sessionKey,
    string routeKey,
    string? applicationKey,
    string? userEmail = null!)
    : MyBaseCommand(aggregateId, idempotencyKey, sessionKey, routeKey, applicationKey, userEmail),
        IRequest;