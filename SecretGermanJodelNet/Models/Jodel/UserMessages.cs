using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class UserMessages
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }
}
