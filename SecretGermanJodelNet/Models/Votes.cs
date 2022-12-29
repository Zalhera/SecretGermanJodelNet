using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Votes
    {
        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("user_voted")]
        public int UserVoted { get; set; }

        [JsonPropertyName("thanks")]
        public int Thanks { get; set; }

        [JsonIgnore]
        public bool HasUserVoted => UserVoted == 1;
    }
}
