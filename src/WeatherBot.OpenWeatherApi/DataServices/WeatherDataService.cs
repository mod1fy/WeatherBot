using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using WeatherBot.Core.DataServices;
using WeatherBot.Core.Models;
using WeatherBot.OpenWeatherApi.Mappers;
using WeatherBot.OpenWeatherApi.ResponseModels;

namespace WeatherBot.OpenWeatherApi.DataServices
{
    public class WeatherDataService : IWeatherDataService
    {
        private readonly OpenWeatherOptions _openWeatherOptions;
        private readonly IHttpClientFactory _httpClientFactory; 

        public WeatherDataService(IOptions<OpenWeatherOptions> options, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _openWeatherOptions = options.Value;
        }

        public async Task<LocationWeatherInfo> GetCurrentWeather(string locationName)
        {
            var requestUrl = $"{_openWeatherOptions.BaseUrl}/weather?" +
                             $"q={locationName}&units=metric&appid={_openWeatherOptions.OpenWeatherApiToken}";

            using var httpClient = _httpClientFactory.CreateClient();
            var response = await httpClient.GetAsync(requestUrl);
            var parsedResponse = await response.Content.ReadFromJsonAsync<OpenWeatherResponse>()
                ?? throw new ApplicationException("Could not parse current weather response.");
            return parsedResponse.ToDomain();
        }
    }
}