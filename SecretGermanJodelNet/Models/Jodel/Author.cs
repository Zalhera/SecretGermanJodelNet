using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class Author
    {
        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("gender_id")]
        public int GenderId { get; set; }

        [JsonPropertyName("verified")]
        public int Verified { get; set; }

        [JsonPropertyName("donator")]
        public int Donator { get; set; }

        [JsonPropertyName("premium")]
        public int Premium { get; set; }

        [JsonPropertyName("user_author")]
        public int UserAuthor { get; set; }

        [JsonPropertyName("user_adminflag")]
        public int UserAdminflag { get; set; }

        [JsonPropertyName("user_messages")]
        public UserMessages? UserMessages { get; set; }
    }
}
