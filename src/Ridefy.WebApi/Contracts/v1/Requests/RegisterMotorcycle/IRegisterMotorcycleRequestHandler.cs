using MediatR;
using Microsoft.AspNetCore.Mvc;
using Ridefy.WebApi.Contracts.v1.Responses;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterMotorcycle;

public interface IRegisterMotorcycleRequestHandler : IRequestHandler<RegisterMotorcycleRequest, MotorcycleCommandStatusResponse>
{
    
}