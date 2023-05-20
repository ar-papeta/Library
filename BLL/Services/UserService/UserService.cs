
using BLL.Dtos;
using BLL.Helpers.PasswordHasher;
using DAL.Db.Uof;
using DAL.Models;

namespace BLL.Services.UserService;

public class UserService : IUserService
{
    private readonly IUnitOfWork _database;
    private readonly IPasswordHash _passwordHash;

    public UserService(IUnitOfWork database, IPasswordHash passwordHash)
    {
        _database = database;
        _passwordHash = passwordHash;
    }

    public UserDto CreateUser(UserDto userDto)
    {
        if (userDto is null)
        {
            throw new Exception("Access denied. Unresolved user from request body.");
        }

        var user = new User
        {
            Name = userDto.Name,
            EMail = userDto.EMail,  //USE AUTOMAPPER OR CREATE MAPPER FOR THIS
            Id = Guid.NewGuid(),
            Role = Role.User,
            Password = userDto.Password,
        };
        user.Password = _passwordHash.EncryptPassword(user.Password, user.Id.ToByteArray());

        _database.Users.Insert(user);
        _database.Save();

        return userDto;
    }

    public UserDto EditUser(UserDto userDto, Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UserDto> GetUsers()
    {
        var users = _database.Users.Get().ToList();
        var usersDto = new List<UserDto>();
        foreach (var user in users)
        {
            usersDto.Add(
                new UserDto 
                { 
                    Name = user.Name, 
                    EMail = user.EMail,             //USE AUTOMAPPER OR CREATE MAPPER FOR THIS
                    Id = user.Id
                }
                );
        }
        return usersDto;
    }

    public UserDto ValidateUser(UserDto userDto)
    {
        throw new NotImplementedException();
    }
}
