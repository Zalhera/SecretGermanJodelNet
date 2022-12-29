using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record JodelVoteResponse
    {
        [JsonPropertyName("jodelid")]
        public int JodelId { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
