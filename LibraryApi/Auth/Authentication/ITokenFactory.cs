namespace LibraryApi.Auth.Authentication;

public interface ITokenFactory
{
    public string CreateJwtAccessToken(string userId, string userRole);
}
