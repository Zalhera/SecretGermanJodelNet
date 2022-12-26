using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class JodelResponse
    {
        [JsonPropertyName("view")]
        public View? View { get; set; }

        [JsonPropertyName("jodels")]
        public List<Jodel> Jodels { get; set; } = new List<Jodel>();
    }
}
