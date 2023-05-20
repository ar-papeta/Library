using BLL.Helpers.PasswordHasher;
using BLL.Services.UserService;
using DAL.Extentions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extentions;

public static class ServiceCollectionExt
{

    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddDALServices();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IPasswordHash, PasswordHash>();
        return services;
    }
}
