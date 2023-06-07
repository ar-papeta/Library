using BLL.Helpers.PasswordHasher;
using DAL.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extentions;

public static class ServiceCollectionExt
{

    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddDALServices();
        services.AddScoped<IPasswordHash, PasswordHash>();
        return services;
    }
}
