using System.Threading.Tasks;
using WeatherBot.Core.Models;

namespace WeatherBot.Core.DataServices
{
    public interface IWeatherDataService
    {
        Task<LocationWeatherInfo> GetCurrentWeather(string locationName);
    }
}