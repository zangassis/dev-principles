namespace DevPrinciples.Data;

public interface IWeatherRepository
{
    Task<string> GetForecastAsync(string location);
    Task SaveForecastAsync(string location, string external);
}