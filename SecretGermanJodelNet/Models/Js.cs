using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Js
    {
        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;
    }
}
