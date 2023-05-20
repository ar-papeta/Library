
using System.Text.Json.Serialization;

namespace BLL.Dtos;

public class UserDto
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("emai")]
    public string EMail { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }
}

