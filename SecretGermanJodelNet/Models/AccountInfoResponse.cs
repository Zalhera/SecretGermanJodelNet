using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record AccountInfoResponse
    {
        [JsonPropertyName("account")]
        public Account Account { get; set; } = default!;

        [JsonPropertyName("js")]
        public Js Js { get; set; } = default!;

        [JsonPropertyName("max_lifetime")]
        public int MaxLifetime { get; set; }
    }
}
