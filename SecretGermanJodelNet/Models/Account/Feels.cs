using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Feels
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("html")]
        public string Html { get; set; } = string.Empty;

        [JsonPropertyName("all")]
        public List<string> All { get; set; } = new List<string>();
    }
}
