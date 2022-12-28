using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Donator
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }
    }
}
