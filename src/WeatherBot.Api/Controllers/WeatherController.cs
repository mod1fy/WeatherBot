using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherBot.Core.DataServices;

namespace WeatherBot.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private readonly IWeatherDataService _weatherDataService;

        public WeatherController(IWeatherDataService weatherDataService)
        {
            _weatherDataService = weatherDataService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCurrentWeather([FromQuery]string location)
        {
            var weatherForLocation = await _weatherDataService.GetCurrentWeather(location);
            return Ok(weatherForLocation);
        }
    }
}