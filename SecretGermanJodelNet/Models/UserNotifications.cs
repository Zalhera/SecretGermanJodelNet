using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
#warning TODO: Find out what these mean
    public record UserNotifications
    {
        [JsonPropertyName("type1")]
        public int Type1 { get; set; }

        [JsonPropertyName("type2")]
        public int Type2 { get; set; }

        [JsonPropertyName("type3")]
        public int Type3 { get; set; }

        [JsonPropertyName("type8")]
        public int Type8 { get; set; }

        [JsonPropertyName("type9")]
        public int Type9 { get; set; }

        [JsonPropertyName("type4")]
        public int Type4 { get; set; }

        [JsonPropertyName("type5")]
        public int Type5 { get; set; }
    }
}
