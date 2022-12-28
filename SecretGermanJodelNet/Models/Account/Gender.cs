using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Gender
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("emoji")]
        public string Emoji { get; set; } = string.Empty;

        [JsonPropertyName("emoji_skin")]
        public int EmojiSkin { get; set; }
    }
}
