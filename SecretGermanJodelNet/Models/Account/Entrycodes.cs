using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Entrycodes
    {
        [JsonPropertyName("info")]
        public EntrycodeInfo Info { get; set; } = default!;

        [JsonPropertyName("free")]
        public int Free { get; set; }
    }
}
