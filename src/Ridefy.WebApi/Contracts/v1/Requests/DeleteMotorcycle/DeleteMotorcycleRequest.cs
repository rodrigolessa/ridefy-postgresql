using Microsoft.AspNetCore.Mvc;
using Ridefy.Infrastructure.Cqrs.Requests;

namespace Ridefy.WebApi.Contracts.v1.Requests.DeleteMotorcycle;

public class DeleteMotorcycleRequest : MyBaseRequest<ObjectResult>
{
    public required string ExternalId { get; set; }
}