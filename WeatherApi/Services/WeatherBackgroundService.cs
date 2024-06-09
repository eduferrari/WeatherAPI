using WeatherApi.Repository;

namespace WeatherApi.Services;

public class WeatherBackgroundService : BackgroundService
{
    private readonly IWeatherService _weatherService;
    private readonly IWeatherRepository _weatherRepository;
    private readonly ILogger<WeatherBackgroundService> _logger;
    private readonly string[] _cities = { "Porto Alegre", "Florianópolis", "Curitiba" };

    public WeatherBackgroundService(IWeatherService weatherService, IWeatherRepository weatherRepository, ILogger<WeatherBackgroundService> logger)
    {
        _weatherService = weatherService;
        _weatherRepository = weatherRepository;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            foreach (var city in _cities)
            {
                try
                {
                    var data = await _weatherService.GetWeatherDataAsync(city);
                    _weatherRepository.AddWeatherData(city, data);
                    _logger.LogInformation($"Dados do tempo de {city} registrados às {DateTime.Now}");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Erro ao buscar dados para {city}");
                }
            }
            await Task.Delay(TimeSpan.FromMinutes(2), stoppingToken);
        }
    }
}