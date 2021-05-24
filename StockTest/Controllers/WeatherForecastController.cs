using StockTest.Services;
using Microsoft.AspNetCore.Mvc;
using StockTest.Models;

namespace StockTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherService _weatherService;


        public WeatherForecastController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }



        [HttpGet]
        public WeatherForecast Get()
        {

            var weatherForecast = _weatherService.GetWeather();

            return weatherForecast;
        }
    }
}

