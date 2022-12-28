using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public record Color
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
