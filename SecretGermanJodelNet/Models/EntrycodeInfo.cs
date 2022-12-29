using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record EntrycodeInfo
    {
        [JsonPropertyName("restriction")]
        public int Restriction { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("premium_free")]
        public int PremiumFree { get; set; }

        [JsonPropertyName("max_usable")]
        public int MaxUsable { get; set; }

        [JsonPropertyName("max_active")]
        public int MaxActive { get; set; }
    }
}
