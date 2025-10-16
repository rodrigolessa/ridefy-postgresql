namespace Ridefy.Infrastructure.Messaging.Abstractions;

public interface IEventPublisher
{
    Task PublishAsync(IEvent @event, int? delayInSeconds = null);
    Task PublishAsync(IList<IEvent> events, int? delayInSeconds = null);
}