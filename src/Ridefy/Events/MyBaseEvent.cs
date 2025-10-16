using MediatR;
namespace Ridefy.Events;

public class MyBaseEvent : IEvent, IRequest
{
    public string IdempotencyKey { get; set; }
    public string AggregateId { get; set; }
    public DateTimeOffset EventCommittedTimestamp { get; set; }
    
    public MyBaseEvent(string idempotencyKey, string aggregateId, TimeProvider timeProvider)
    {
        IdempotencyKey = idempotencyKey;
        AggregateId = aggregateId;
        EventCommittedTimestamp = timeProvider.GetUtcNow();
    }
}