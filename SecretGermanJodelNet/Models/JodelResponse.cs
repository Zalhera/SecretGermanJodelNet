using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record JodelResponse
    {
        [JsonPropertyName("jodel")]
        public Jodel Jodel { get; set; } = default!;
    }
}
