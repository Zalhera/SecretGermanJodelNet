using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class Jodel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("imageA")]
        public string? Gif { get; set; }

        [JsonPropertyName("video")]
        public string? Video { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }

        [JsonPropertyName("color")]
        public Color? Color { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("votes")]
        public Votes? Votes { get; set; }

        [JsonPropertyName("author")]
        public Author? Author { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("pinned")]
        public int Pinned { get; set; }

        [JsonPropertyName("report")]
        public int Report { get; set; }
    }
}
