
using BLL.Dtos;

namespace BLL.Services.UserService;

public interface IUserService
{
    public UserDto CreateUser(UserDto userDto);
    public IEnumerable<UserDto> GetUsers();
    public UserDto ValidateUser(UserDto userDto);
    public UserDto EditUser(UserDto userDto, Guid id);
}
