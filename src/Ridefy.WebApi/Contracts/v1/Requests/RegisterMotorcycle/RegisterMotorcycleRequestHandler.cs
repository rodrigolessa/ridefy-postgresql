using Microsoft.AspNetCore.Mvc;
using Ridefy.Application.Commands.RegisterMotorcycle;
using Ridefy.Infrastructure.Messaging.Abstractions;
using Ridefy.Models;
using Ridefy.WebApi.Contracts.v1.Responses;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterMotorcycle;

public class RegisterMotorcycleRequestHandler : IRegisterMotorcycleRequestHandler
{
    private ICommandPublisher _commandPublisher;

    public RegisterMotorcycleRequestHandler(ICommandPublisher commandPublisher)
    {
        _commandPublisher = commandPublisher;
    }

    public async Task<MotorcycleCommandStatusResponse> Handle(RegisterMotorcycleRequest request, CancellationToken cancellationToken)
    {
        var id = MotorcycleId.New();
        var command = new RegisterMotorcycleCommand(
            id,
            request.ExternalId,
            request.Year,
            request.Model,
            request.Plate,
            request.IdempotencyKey,
            request.ClientApplication,
            request.UserEmail
        ) { };

        await _commandPublisher.PublishAsync(command, "", command.RouteKey, cancellationToken);

        return new MotorcycleCommandStatusResponse(command.IdempotencyKey, id);
    }
}