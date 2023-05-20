
using System.Text.Json.Serialization;

namespace Library.ViewModels;

public class RegistrationViewModel
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("emai")]
    public string EMail { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("Name")]
    public string Name { get; set; }
}
