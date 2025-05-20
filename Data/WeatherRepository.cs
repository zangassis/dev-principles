using DevPrinciples.Models;
using Microsoft.EntityFrameworkCore;

namespace DevPrinciples.Data;

public class WeatherRepository: DbContext {

    public WeatherRepository(DbContextOptions<WeatherRepository> options) : base(options) { }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}