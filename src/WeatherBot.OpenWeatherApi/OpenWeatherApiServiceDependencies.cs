using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherBot.Core.DataServices;
using WeatherBot.OpenWeatherApi.DataServices;

namespace WeatherBot.OpenWeatherApi
{
    public static class OpenWeatherApiServiceDependencies
    {
        public static IServiceCollection AddOpenWeatherApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IWeatherDataService, WeatherDataService>();
            return services;
        }
    }
}