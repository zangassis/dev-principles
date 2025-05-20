namespace DevPrinciples.Data;

public interface IExternalWeatherApi
{
    Task<string> FetchForecastAsync(string location);
}