using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record LoginResponse
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("first")]
        public int First { get; set; }
    }
}
