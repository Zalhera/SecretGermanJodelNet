using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class Color
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
