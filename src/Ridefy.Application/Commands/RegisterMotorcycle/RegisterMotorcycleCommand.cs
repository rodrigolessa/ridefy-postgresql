using Ridefy.Application.Configurations;
using Ridefy.Infrastructure.Cqrs.Commands;
using Ridefy.Models;

namespace Ridefy.Application.Commands.RegisterMotorcycle;

public sealed class RegisterMotorcycleCommand(
    MotorcycleId aggregateId,
    string externalId,
    int year,
    string model,
    string plate,
    string? idempotencyKey,
    string? applicationKey,
    string? userEmail = null!)
    : Command(
        aggregateId.ToString(),
        idempotencyKey,
        sessionKey: aggregateId.ToString(),
        MessageBrokerConstants.RegistrationRoute,
        applicationKey,
        userEmail)
{
    public string ExternalId { get; set; } = externalId;
    public int YearOfManufacture { get; set; } = year;
    public string Model { get; set; } = model;
    public string Plate { get; set; } = plate;
}