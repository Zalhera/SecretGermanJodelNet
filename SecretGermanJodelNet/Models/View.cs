using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record View
    {
        [JsonPropertyName("main")]
        public int Main { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
