using Microsoft.AspNetCore.Mvc;

namespace Ridefy.WebApi.Controllers;

public class RidersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}