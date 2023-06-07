using DAL.Db;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Extentions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddDALServices(this IServiceCollection services)
    {
        services.AddDbContext<LibraryContext>();

        return services;
    }
}
