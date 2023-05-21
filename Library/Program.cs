
using Microsoft.Extensions.DependencyInjection;
using BLL.Extentions;
using Library.Controllers;
using Library.ViewModels;
using Microsoft.Extensions.Hosting;

namespace Library;

public class Program
{
    public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddBLLServices();
            services.AddScoped<UserController>();
        });

    public static async Task Main(string[] args)
    {

        var host = CreateHostBuilder(args).Build();

        //await host.RunAsync();

        var provider = host.Services.GetService<UserController>();



        //var serviceProvider = new ServiceCollection()
        //            .AddBLLServices()
        //            .AddSingleton<UserController>()         //ДЕЛЕГУЭМО ФРЕЙМВОРКУ СТВОРЕННЯ ОБ'ЄКТІВ ВСІХ НАШИХ КЛАСІВ (СЕРВІСІВ)
        //            .BuildServiceProvider();


        ////do the actual work here
        //var simulator = serviceProvider.GetService<UserController>();

        //Console.WriteLine("Press 1 to add new USER");
        //RegistrationViewModel newUser = new();
        //while (true)
        //{
        //    if (Console.ReadLine() == "1")
        //        break;
        //}
        //Console.WriteLine("Enter name:");
        //newUser.Name = Console.ReadLine();

        //Console.WriteLine("Enter email:");
        //newUser.EMail = Console.ReadLine();

        //Console.WriteLine("Enter password:");
        //newUser.Password = Console.ReadLine();

        //provider.AddUser(newUser);

        Console.WriteLine("Press 2 to get users list");
        while (true)
        {
            if (Console.ReadLine() == "2")
                break;
        }

        var users = provider.GetAllUsers();
        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}