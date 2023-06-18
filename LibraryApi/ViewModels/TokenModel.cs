using System.Text.Json.Serialization;

namespace LibraryApi.ViewModels;

public class TokenModel
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; } = null!;
}
