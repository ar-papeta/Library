using LibraryApi.ViewModels;

namespace LibraryApi.Auth;

public interface IAuthService
{
    public TokenModel CreateNewTokenModel(string userId, string userRole);
    public AuthenticateResponce AuthenticateUser(AuthenticationRequest request);
}
