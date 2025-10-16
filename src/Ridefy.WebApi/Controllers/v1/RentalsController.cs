using Microsoft.AspNetCore.Mvc;

namespace Ridefy.WebApi.Controllers;

public class RentalsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}