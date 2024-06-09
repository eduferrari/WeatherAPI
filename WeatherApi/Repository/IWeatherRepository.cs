using WeatherApi.Models;
using WeatherApi.Services;

namespace WeatherApi.Repository;

public interface IWeatherRepository
{
    void AddWeatherData(string city, WeatherData data);
    IEnumerable<WeatherDataRecord> GetWeatherData(string city, DateTime startDate, DateTime endDate);
}