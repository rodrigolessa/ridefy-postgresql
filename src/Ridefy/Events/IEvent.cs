namespace Ridefy.Events;

public class IEvent
{
    string IdempotencyKey { get; set; }
    string AggregateId { get; set; }
    DateTime EventCommittedTimestamp { get; set; }
}