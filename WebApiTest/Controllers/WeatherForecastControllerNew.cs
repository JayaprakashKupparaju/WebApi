using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastControllerNew : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastControllerNew(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        
        [HttpGet(Name = "GetWeatherForecastNew")]
        public IEnumerable<WeatherForecastNew> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecastNew
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
