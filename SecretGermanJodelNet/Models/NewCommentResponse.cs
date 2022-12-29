using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record NewCommentResponse
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
