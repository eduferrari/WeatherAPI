using Moq.Protected;
using Moq;
using System.Net;
using WeatherApi.Services;
using FluentAssertions;

namespace WeatherTests;
public class WeatherServiceTests
{
    [Fact]
    public async Task GetWeatherDataAsync_ShouldReturnWeatherData()
    {
        // Arrange
        var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
        mockHttpMessageHandler
            .Protected()
            .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
            .ReturnsAsync(new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{\"main\":{\"temp\":25.5}}"),
            });

        var httpClient = new HttpClient(mockHttpMessageHandler.Object);
        var weatherService = new WeatherService(httpClient);

        // Act
        var result = await weatherService.GetWeatherDataAsync("Porto Alegre");

        // Assert
        result.Main.Temp.Should().Be(25.5f);
    }
}
