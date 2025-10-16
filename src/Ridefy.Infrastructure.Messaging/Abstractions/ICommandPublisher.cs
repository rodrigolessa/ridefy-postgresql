using Ridefy.Infrastructure.Cqrs.Commands;

namespace Ridefy.Infrastructure.Messaging.Abstractions;

public interface ICommandPublisher
{
    Task PublishAsync(IBaseCommand command,
        string exchange = "",
        string route = "",
        CancellationToken cancellationToken = default);
    Task PublishAsync<T>(List<T> commands,
        string exchange = "",
        string route = "",
        int? delayInSeconds = null)
        where T : IBaseCommand;
}