using FluentAssertions;
using WeatherApi.Repository;
using WeatherApi.Services;

namespace WeatherTests;
public class WeatherRepositoryTests
{
    [Fact]
    public void AddWeatherData_ShouldStoreWeatherData()
    {
        // Arrange
        var repository = new WeatherRepository();
        var weatherData = new WeatherData
        {
            Main = new MainData { Temp = 25.5f }
        };

        // Act
        repository.AddWeatherData("Porto Alegre", weatherData);

        // Assert
        var storedData = repository.GetWeatherData("Porto Alegre", DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(1)).ToList();
        storedData.Should().HaveCount(1);
        storedData.First().Temperature.Should().Be(25.5f);
    }

    [Fact]
    public void GetWeatherData_ShouldReturnCorrectData()
    {
        // Arrange
        var repository = new WeatherRepository();
        var weatherData = new WeatherData
        {
            Main = new MainData { Temp = 25.5f }
        };
        repository.AddWeatherData("Porto Alegre", weatherData);

        // Act
        var result = repository.GetWeatherData("Porto Alegre", DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(1));

        // Assert
        result.Should().NotBeEmpty();
    }
}
