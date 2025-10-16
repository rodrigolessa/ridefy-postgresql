using MediatR;
using Ridefy.Models.Enumerations;
using EnvironmentName = Microsoft.AspNetCore.Hosting.EnvironmentName;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterRider;

public record RegisterRiderRequest<TResponse>(string ExternalId, string Name, string DocumentNumber, DateTime DateOfBirth, string DriveLicenseNumber, DriveLicenseType DriveLicenseType, string DriveLicenseImage) : IRequest<TResponse>;