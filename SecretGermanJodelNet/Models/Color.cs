using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Color
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
