using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Ridefy.Infrastructure.Cqrs.Requests;
using Ridefy.WebApi.Contracts.v1.Responses;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterMotorcycle;

public class RegisterMotorcycleRequest : MyBaseRequest<MotorcycleCommandStatusResponse>
{
    [JsonPropertyName("identificador")]
    public required string ExternalId { get; set; }
    [JsonPropertyName("ano")]
    public required int Year { get; set; }
    [JsonPropertyName("modelo")]
    public required string Model { get; set; }
    [JsonPropertyName("placa")]
    public required string Plate { get; set; }
}