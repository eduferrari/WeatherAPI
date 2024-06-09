
namespace WeatherApi.Services;

public interface IWeatherService
{
    Task<WeatherData> GetWeatherDataAsync(string city);
}

