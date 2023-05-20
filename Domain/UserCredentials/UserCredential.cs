using System.ComponentModel;
using System.Text.Json.Serialization;
namespace Domain.UserCredentials;
public class UserCredential
{
    [JsonPropertyName("username")]
    public string UserName { get; set; }

    [PasswordPropertyText]
    public string Password { get; set; }
}


