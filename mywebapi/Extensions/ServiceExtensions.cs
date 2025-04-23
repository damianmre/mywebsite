using mywebapi.Repositories;
using mywebapi.Repositories.IRepositories;
using mywebapi.Services;

namespace mywebapi.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IWoordenschatRepository, WoordenschatRepository>();
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<WoordenschatService>();
    }
}
