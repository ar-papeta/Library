using BLL.Helpers.PasswordHasher;
using BLL.Services.BookService;
using BLL.Services.VisitorService;
using DAL.Extentions;
using Microsoft.Extensions.DependencyInjection;

namespace BLL.Extentions;

public static class ServiceCollectionExt
{

    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddDALServices();
        services.AddScoped<IPasswordHash, PasswordHash>();
        services.AddScoped<IBookService, BookService>();
        services.AddScoped<IVisitorService, VisitorService>();
        return services;
    }
}
