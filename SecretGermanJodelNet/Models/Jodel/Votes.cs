using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public record Votes
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("user_voted")]
        public int UserVoted { get; set; }
    }
}
