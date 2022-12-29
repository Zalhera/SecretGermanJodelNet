using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record UserMessages
    {
        [JsonPropertyName("all")]
        public int All { get; set; }

        [JsonPropertyName("oj")]
        public int Oj { get; set; }
    }
}
