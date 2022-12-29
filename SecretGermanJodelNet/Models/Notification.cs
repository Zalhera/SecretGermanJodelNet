using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Notification
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("unread")]
        public int Unread { get; set; }

        [JsonPropertyName("jodel")]
        public Jodel Jodel { get; set; } = default!;

        [JsonPropertyName("comment")]
        public Comment Comment { get; set; } = default!;

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("hashtags")]
        public List<string> Hashtags { get; set; } = new List<string>();
    }
}
