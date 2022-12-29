using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record UserEmoji
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; } = string.Empty;
    }
}
