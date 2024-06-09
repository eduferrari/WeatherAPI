namespace WeatherApi.Services;

public class WeatherData
{
    public MainData Main { get; set; }
}

public class MainData
{
    public float Temp { get; set; }
}