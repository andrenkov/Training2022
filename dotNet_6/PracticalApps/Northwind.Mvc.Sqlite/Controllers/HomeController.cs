﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Mvc.Models;
using Northwind.Mvc.Sqlite.Models;
using Packt.Shared;

namespace Northwind.Mvc.Sqlite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly northwindContext db;
    #region Added for HttpClientFactory
    private readonly IHttpClientFactory clientFactory;
    #endregion

    /// <summary>
    /// <param name="logger"></param>
    /// </summary>
    public HomeController(ILogger<HomeController> logger, northwindContext injectedDbContect, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        db = injectedDbContect;
        #region Added for HttpClientFactory
        clientFactory = httpClientFactory;
        #endregion
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

    /// <summary>
    /// Filters:
    /// </summary>
    //[Authorize(Roles = "Admin, SuperUser")]
    [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any)]//tell Browser to cache the responses for 10 sec
                                                                        //[Route("MyIndex")]//custom route
    public async Task<IActionResult> Index()
    {
        _logger.LogWarning("Here's the warning");
        try
        {
            _logger.LogInformation("Here's the info");

            HomeIndexViewModel model = new
                (
                    VisitorsCount: new Random().Next(1, 1001),
                    Categories: await db.Categories.ToListAsync(),
                    Products: await db.Products.ToListAsync()
                );
            return View(model);//pass model to View
        }
        catch (Exception ex)
        {
            _logger.LogError("Error: " + ex.Message);
        }


        return View();
    }
    /// <summary>
    /// Show one product details
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> ProductDetail(int? id)
    {
        if (!id.HasValue)
        { 
            return BadRequest("You must pass the product Id, for example, /21");
        }

        Product? model = await db.Products
            .SingleOrDefaultAsync(p => p.ProductId == id);
        if (model == null)
        { 
            return NotFound($"ProductId {id} not found");
        }

        return View(model);
    }

    /// <summary>
    /// Show products with tegh cost > N
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> ProductThatCostMoreThan(decimal? price)
    {
        if (!price.HasValue)
        {
            return BadRequest("You must pass the product price");
        }

        IEnumerable<Product> model = await db.Products
            .Include(p => p.Category)
            .Include(p => p.Supplier)
            .Where(p => p.UnitPrice > price).ToArrayAsync();


        if (!model.Any())
        {
            return NotFound($"No Products cost more that {price} not found");
        }

        ViewBag.MaxPrice = price.Value.ToString();
        return View(model);
    }

    #region Added for HttpClientFactory
    /// <summary>
    /// Action to call WebApi
    /// </summary>
    /// <param name="country"></param>
    /// <returns></returns>
    public async Task<IActionResult> Customers(string country)
    {
        string uri;

        if (string.IsNullOrEmpty(country))
        {
            ViewData["Title"] = "All Customers Worldwide";
            uri = "api/customers/";
        }
        else
        {
            ViewData["Title"] = $"Customers in {country}";
            uri = $"api/customers/?country={country}";
        }

        #region Http call

        HttpClient client = clientFactory.CreateClient(name: "Northwind.WebApi");

        HttpRequestMessage request = new(method: HttpMethod.Get, requestUri: uri);

        HttpResponseMessage response = await client.SendAsync(request);

        IEnumerable<Customer>? model = await response.Content.ReadFromJsonAsync<IEnumerable<Customer>>();

        #endregion

        return View(model);
    }
    #endregion
}