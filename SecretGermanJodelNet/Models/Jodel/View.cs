using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class View
    {
        [JsonPropertyName("main")]
        public int Main { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
