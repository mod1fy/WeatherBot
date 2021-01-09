using System;
using System.Linq;
using WeatherBot.Core.Models;
using WeatherBot.OpenWeatherApi.ResponseModels;
using Weather = WeatherBot.Core.Models.Weather;

namespace WeatherBot.OpenWeatherApi.Mappers
{
    public static class LocationWeatherInfoMapper
    {
        public static LocationWeatherInfo ToDomain(this OpenWeatherResponse response)
        {
            var weather = response.Weather.FirstOrDefault() ?? 
                          throw new ArgumentException("Response does not contain weather info.");
            return new LocationWeatherInfo
            {
                LocationName = response.Name,
                Weather = new Weather
                {
                    DescriptionShort = weather.Main,
                    IconCode = weather.Icon,
                    Description = weather.Description,
                    CurrentTemperature = response.Main.Temp,
                    MaximumTemperature = response.Main.TempMax,
                    MinimumTemperature = response.Main.TempMin,
                    WindSpeed = response.Wind.Speed
                }
            };
        }
            
    }
}