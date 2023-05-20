using System.Text.Json.Serialization;
namespace Domain.Tokens;
public class Token
{
    [JsonPropertyName("acces_token")]
    public string AccesToken { get; set; }
    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }
}
