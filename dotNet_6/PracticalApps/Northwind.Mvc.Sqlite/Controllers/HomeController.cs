using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Northwind.Mvc.Models;
using Northwind.Mvc.Sqlite.Models;
using Packt.Shared;

namespace Northwind.Mvc.Sqlite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly northwindContext db;
    /// <summary>
    /// <param name="logger"></param>
    /// </summary>
    public HomeController(ILogger<HomeController> logger, northwindContext injectedDbContect)
    {
        _logger = logger;
        db = injectedDbContect;
    }
    /// <summary>
    /// Filters:
    /// </summary>
    //[Authorize(Roles = "Admin, SuperUser")]
    [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)]//tell Browser to cache the responses for 10 sec
                                                                        //[Route("MyIndex")]//custom route
    public IActionResult Index()
    {
        _logger.LogWarning("Here's the warning");
        try
        {
            _logger.LogInformation("Here's the info");

            HomeIndexViewModel model = new
                (
                    VisitorsCount: new Random().Next(1, 1001),
                    Categories: db.Categories.ToList(),
                    Products: db.Products.ToList()
                );
            return View(model);//pass model to View
        }
        catch (Exception ex)
        {
            _logger.LogError("Error: " + ex.Message);
        }


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        _logger.LogError($"Error in: {Activity.Current?.Id}");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
