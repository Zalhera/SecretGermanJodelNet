using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Notifications
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("general")]
        public int General { get; set; }

        [JsonPropertyName("messages")]
        public int Messages { get; set; }

        [JsonPropertyName("reports")]
        public int Reports { get; set; }
    }
}
