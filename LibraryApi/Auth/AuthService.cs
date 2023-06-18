using BLL.Helpers.PasswordHasher;
using BLL.Services.VisitorService;
using DAL.Entities.PersonsEntities;
using LibraryApi.Auth.Authentication;
using LibraryApi.ViewModels;

namespace LibraryApi.Auth;

public class AuthService : IAuthService
{
    private readonly ITokenFactory _tokenFactory;
    private readonly IPasswordHash _passwordHash;
    private readonly IVisitorService _visitorService;

    public AuthService(
        ITokenFactory tokenFactory,
        IPasswordHash passwordHash
,
        IVisitorService visitorService)
    {
        _tokenFactory = tokenFactory;
        _passwordHash = passwordHash;
        _visitorService = visitorService;
    }

    public TokenModel CreateNewTokenModel(string userId, string userRole)
    {
        return new()
        {
            AccessToken = _tokenFactory.CreateJwtAccessToken(userId, userRole)
        };
    }

    public AuthenticateResponce AuthenticateUser(AuthenticationRequest request)
    {
        if (request is null)
        {
            throw new Exception("Access denied. Unresolved request from request body.");
        }

        Visitor user = _visitorService.GetVisitors(user =>
            user.Email == request.Email)
            .FirstOrDefault()
           ?? throw new Exception("Access denied. Unresolved email.");

        var incomingPasswordHash = _passwordHash.EncryptPassword(request.Password, user.Id.ToByteArray());

        if (incomingPasswordHash != user.Password) 
        {
            throw new Exception("Access denied. Incorrect password.");
        }

        return new()
        {
            AccessToken = _tokenFactory.CreateJwtAccessToken(user.Id.ToString(), user.Role.ToString()),
            UserViewModel = new()
            {
                EMail = user.Email,
                Role = user.Role.ToString(),
                Id = user.Id,
                Name = user.Name
            }
        };
    }
}
