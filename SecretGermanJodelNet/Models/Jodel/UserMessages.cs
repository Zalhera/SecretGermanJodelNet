using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public record UserMessages
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }
}
