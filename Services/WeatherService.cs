using DevPrinciples.Data;

public class WeatherService
{
    private readonly IWeatherRepository _repository;
    private readonly IExternalWeatherApi _api;

    public WeatherService(IWeatherRepository repository, IExternalWeatherApi api)
    {
        _repository = repository;
        _api = api;
    }

    public async Task<string> GetWeatherForecastAsync(string location)
    {
        if (string.IsNullOrWhiteSpace(location)) 
            throw new ArgumentException("Location is required");

        var cached = await _repository.GetForecastAsync(location);
        if (cached != null)
            return cached;

        var external = await _api.FetchForecastAsync(location);
        await _repository.SaveForecastAsync(location, external);
        return external;
    }
}
