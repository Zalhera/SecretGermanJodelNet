using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record JodelsResponse
    {
        [JsonPropertyName("view")]
        public View View { get; set; } = default!;

        [JsonPropertyName("jodels")]
        public List<Jodel> Jodels { get; set; } = new List<Jodel>();
    }
}
