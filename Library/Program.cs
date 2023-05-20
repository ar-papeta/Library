
using Microsoft.Extensions.DependencyInjection;
using BLL.Extentions;
using Library.Controllers;
using Library.ViewModels;

var serviceProvider = new ServiceCollection()
            .AddBLLServices()
            .AddSingleton<UserController>()         //ДЕЛЕГУЭМО ФРЕЙМВОРКУ СТВОРЕННЯ ОБ'ЄКТІВ ВСІХ НАШИХ КЛАСІВ (СЕРВІСІВ)
            .BuildServiceProvider();

//do the actual work here
var simulator = serviceProvider.GetService<UserController>();

Console.WriteLine("Press 1 to add new USER");
RegistrationViewModel newUser = new();
while (true)
{
    if (Console.ReadLine() == "1")
        break;
}
Console.WriteLine("Enter name:");
newUser.Name = Console.ReadLine();

Console.WriteLine("Enter email:");
newUser.EMail = Console.ReadLine();

Console.WriteLine("Enter password:");
newUser.Password = Console.ReadLine();

simulator.AddUser(newUser);

Console.WriteLine("Press 2 to get users list");
while (true)
{
    if (Console.ReadLine() == "2")
        break;
}

var users = simulator.GetAllUsers();
foreach (var user in users)
{
    Console.WriteLine(user.Name);
}
