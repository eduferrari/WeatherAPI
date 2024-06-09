using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WeatherApi.Controller;
using WeatherApi.Models;
using WeatherApi.Repository;

namespace WeatherTests;
public class WeatherControllerTests
{
    [Fact]
    public void GetWeatherData_ShouldReturnOkResult()
    {
        // Arrange
        var mockRepository = new Mock<IWeatherRepository>();
        mockRepository.Setup(repo => repo.GetWeatherData(It.IsAny<string>(), It.IsAny<DateTime>(), It.IsAny<DateTime>()))
            .Returns(new List<WeatherDataRecord>
            {
                new WeatherDataRecord
                {
                    City = "Porto Alegre",
                    Temperature = 25.5f,
                    Timestamp = DateTime.Now
                }
            });

        var controller = new WeatherController(mockRepository.Object);

        // Act
        var result = controller.GetWeatherData("Porto Alegre", DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(1));

        // Assert
        var okResult = result as OkObjectResult;
        okResult.Should().NotBeNull();
        okResult.StatusCode.Should().Be(200);

        var data = okResult.Value as IEnumerable<WeatherDataRecord>;
        data.Should().NotBeEmpty();
    }
}
