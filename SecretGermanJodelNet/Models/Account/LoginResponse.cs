using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public class LoginResponse
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("first")]
        public int First { get; set; }
    }
}
