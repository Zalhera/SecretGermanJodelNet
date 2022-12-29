using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record CommentResponse
    {
        [JsonPropertyName("direction")]
        public int Direction { get; set; }

        [JsonPropertyName("all_loaded")]
        public int AllLoaded { get; set; }

        [JsonPropertyName("jodel")]
        public Jodel Jodel { get; set; } = default!;

        [JsonPropertyName("comments")]
        public List<Comment> Comments { get; set; } = new List<Comment>();

        [JsonPropertyName("view")]
        public int View { get; set; }
    }
}
