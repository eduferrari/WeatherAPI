using Microsoft.AspNetCore.Mvc;
using WeatherApi.Models;
using WeatherApi.Repository;

namespace WeatherApi.Controller;
[Route("api/[controller]")]
[ApiController]
public class WeatherController : ControllerBase
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherController(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    [HttpGet]
    public IActionResult GetWeatherData([FromQuery] string cities, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
    {
        var result = new List<WeatherDataRecord>();

        foreach (var city in cities.Split(','))
        {
            var cityData = _weatherRepository.GetWeatherData(city, startDate, endDate);
            result.AddRange(cityData);
        }

        return Ok(result);
    }
}
