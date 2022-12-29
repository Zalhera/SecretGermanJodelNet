using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record FavResponse
    {
        [JsonPropertyName("fav")]
        public int Fav { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
