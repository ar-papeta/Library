
using System.Text.Json.Serialization;

namespace DAL.Models;

public enum Role
{
    Admin,
    Manager,
    User,
}

public class User
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("emai")]
    public string EMail { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }

    [JsonIgnore]
    public string Password { get; set; }

    [JsonPropertyName("role")]
    public Role Role { get; set; }
}

