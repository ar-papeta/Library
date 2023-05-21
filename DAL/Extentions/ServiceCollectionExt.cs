using DAL.Db;
using DAL.Db.Uof;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace DAL.Extentions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddDALServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, LibraryUnitOfWork>();
        services.AddDbContext<LibraryContext>();

        return services;
    }
}
