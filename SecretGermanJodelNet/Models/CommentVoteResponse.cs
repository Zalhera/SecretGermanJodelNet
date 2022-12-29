using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record CommentVoteResponse
    {
        [JsonPropertyName("commentid")]
        public int CommentId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("user_author")]
        public int UserAuthor { get; set; }

        [JsonPropertyName("user_author_comment")]
        public int UserAuthorComment { get; set; }
    }
}
