using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebApi.Controllers
{
    [ApiController]//to enablwe RESFull behaviour
    [Route("[controller]")]//localhost:5001/WeatherForecast relative Url
    public class WeatherForecastController : ControllerBase//use ControllerBase fo rno View projects
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        //Get /WeatherForecast
        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //}

        #region New code

        // GET /weatherforecast
        [HttpGet]
        public IEnumerable<WeatherForecast> Get() // original method
        {
            return Get(5); // five day forecast
        }

        //Get /WeatherForecast/5
        [HttpGet("{days:int}")]//route contains int days
        public IEnumerable<WeatherForecast> Get(int days)
        {
            return Enumerable.Range(1, days).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        #endregion
    }
}