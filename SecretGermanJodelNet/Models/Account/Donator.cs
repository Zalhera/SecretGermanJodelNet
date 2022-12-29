using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Donator
    {
        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonIgnore]
        public bool IsActive => Active == 1;
    }
}
