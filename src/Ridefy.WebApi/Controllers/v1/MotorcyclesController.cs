using System.Net.Mime;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Ridefy.Infrastructure.Cqrs.RequestProcessor;
using Ridefy.WebApi.Contracts.v1.Requests.DeleteMotorcycle;
using Ridefy.WebApi.Contracts.v1.Requests.RegisterMotorcycle;
using Ridefy.WebApi.Contracts.v1.Requests.UpdatePlate;
using Ridefy.WebApi.Contracts.v1.Responses;

namespace Ridefy.WebApi.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{v:apiVersion}/motos")]
public class MotorcyclesController : Controller
{
    private readonly ILogger<MotorcyclesController> _logger;
    private readonly IRequestProcessor _processor;
    
    public MotorcyclesController(ILogger<MotorcyclesController> logger, IRequestProcessor processor)
    {
        _logger = logger;
        _processor = processor;
    }
    
    [HttpPost()]
    [Consumes("application/json")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [Tags(nameof(RegisterMotorcycle))]
    public async Task<MotorcycleCommandStatusResponse> RegisterMotorcycle(RegisterMotorcycleRequest request) =>
        await _processor.Process<RegisterMotorcycleRequest, MotorcycleCommandStatusResponse>(request);
    
   

    [HttpPut("{id}/placa")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status404NotFound)]
    [Tags(nameof(UpdatePlate))]
    public async Task<IActionResult> UpdatePlate(UpdatePlateRequest request) =>
        await _processor.Process<UpdatePlateRequest, ObjectResult>(request);

    [HttpDelete("{id}")]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(typeof(ValidationProblemDetails), StatusCodes.Status400BadRequest)]
    [Tags(nameof(DeleteMotorcycle))]
    public async Task<IActionResult> DeleteMotorcycle(DeleteMotorcycleRequest request) =>
        await _processor.Process<DeleteMotorcycleRequest, ObjectResult>(request);
}