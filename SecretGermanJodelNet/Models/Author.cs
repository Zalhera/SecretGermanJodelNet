using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Author
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; } = string.Empty;

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

        [JsonPropertyName("user_oj")]
        public int UserOj { get; set; }

        [JsonPropertyName("user_messages")]
        public UserMessages UserMessages { get; set; } = default!;

        [JsonPropertyName("user_emoji")]
        public UserEmoji UserEmoji { get; set; }

        [JsonPropertyName("user_privatemessage_enabled")]
        public int UserPrivatemessageEnabled { get; set; }

        [JsonIgnore]
        public bool IsVerified => Verified == 1;

        [JsonIgnore]
        public bool IsDonator => Donator == 1;

        [JsonIgnore]
        public bool IsPremium => Premium == 1;

        [JsonIgnore]
        public bool IsUserAuthor => UserAuthor == 1;

        [JsonIgnore]
        public bool IsUserAdmin => UserAdminflag == 1;

        [JsonIgnore]
        public bool IsUserOj => UserOj == 1;

        [JsonIgnore]
        public bool HasUserPrivateMessagesEnabled => UserPrivatemessageEnabled == 1;
    }
}
