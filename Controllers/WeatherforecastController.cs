using Microsoft.AspNetCore.Mvc;

namespace DevPrinciples.Controllers;

public class WeatherForecastController : ControllerBase 
{
    private readonly WeatherService _weatherService;

    public WeatherForecastController(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet("weatherforecast/{location}")]
    public async Task<string> Get(string location)
    {
        return await _weatherService.GetWeatherForecastAsync(location);
    }
}
