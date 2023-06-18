using DAL.Db;
using DAL.Db.Uof;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Extentions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddDALServices(this IServiceCollection services)
    {
        services.AddDbContext<LibraryContext>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;
    }
}
