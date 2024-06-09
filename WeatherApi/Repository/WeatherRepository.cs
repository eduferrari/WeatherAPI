using WeatherApi.Models;
using WeatherApi.Services;

namespace WeatherApi.Repository;

public class WeatherRepository : IWeatherRepository
{
    private readonly List<WeatherDataRecord> _data = new();

    public void AddWeatherData(string city, WeatherData data)
    {
        _data.Add(new WeatherDataRecord
        {
            City = city,
            Temperature = data.Main.Temp,
            Timestamp = DateTime.Now
        });
    }

    public IEnumerable<WeatherDataRecord> GetWeatherData(string city, DateTime startDate, DateTime endDate)
    {
        return _data.Where(d => d.City == city && d.Timestamp >= startDate && d.Timestamp <= endDate).ToList();
    }
}