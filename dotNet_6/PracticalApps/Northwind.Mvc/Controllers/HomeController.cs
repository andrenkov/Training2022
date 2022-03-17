using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.Mvc.Models;
using System.Diagnostics;

namespace Northwind.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        /// <summary>
        /// <param name="logger"></param>
        /// </summary>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Filters:
        /// </summary>
        //[Authorize(Roles = "Admin, SuperUser")]
        //[ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)]//tell Browser to cache the responses for 10 sec
        //[Route("MyIndex")]//custom route
        public IActionResult Index()
        {
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
}