using BLL.Dtos;
using BLL.Services.UserService;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers;

public class UserController
{

    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }
    public UserDto AddUser(RegistrationViewModel newuser)
    {
        UserDto userDto = new UserDto()
        {
            Name = newuser.Name,
            EMail = newuser.EMail,              //USE AUTOMAPPER OR CREATE MAPPER FOR THIS
            Password = newuser.Password,
        };

        _service.CreateUser(userDto);

        return userDto;
    }

    public IEnumerable<UserDto> GetAllUsers()
    {
        return _service.GetUsers();
    }
}
