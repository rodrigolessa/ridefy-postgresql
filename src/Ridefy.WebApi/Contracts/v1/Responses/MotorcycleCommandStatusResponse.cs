using Ridefy.Models;

namespace Ridefy.WebApi.Contracts.v1.Responses;

public record MotorcycleCommandStatusResponse(string IdempotencyKey, MotorcycleId MotorcycleId);