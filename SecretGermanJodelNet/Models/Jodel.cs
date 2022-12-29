using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Jodel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("imageA")]
        public string? Gif { get; set; }

        [JsonPropertyName("video")]
        public string? Video { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; } = default!;

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("media_comments")]
        public int MediaComments { get; set; }

        [JsonPropertyName("votes")]
        public Votes Votes { get; set; } = default!;

        [JsonPropertyName("author")]
        public Author Author { get; set; } = default!;

        [JsonPropertyName("fav")]
        public int Fav { get; set; }

        [JsonPropertyName("user_settings_default")]
        public int UserSettingsDefault { get; set; }

        [JsonPropertyName("user_notifications")]
        public UserNotifications UserNotifications { get; set; } = default!;

        [JsonPropertyName("user_messages")]
        public UserMessages UserMessages { get; set; } = default!;

        [JsonPropertyName("comments_enabled")]
        public int CommentsEnabled { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("pinned")]
        public int Pinned { get; set; }

        [JsonPropertyName("published")]
        public int Published { get; set; }

        [JsonPropertyName("report")]
        public int Report { get; set; }

        [JsonPropertyName("approvals")]
        public List<object> Approvals { get; set; } = new List<object>();

        [JsonPropertyName("additional_information")]
        public string AdditionalInformation { get; set; } = string.Empty;

        [JsonPropertyName("loaded")]
        public int Loaded { get; set; }

        [JsonIgnore]
        public bool IsImage => !string.IsNullOrEmpty(Image);

        [JsonIgnore]
        public bool IsGif => !string.IsNullOrEmpty(Gif);

        [JsonIgnore]
        public bool IsVideo => !string.IsNullOrEmpty(Video);

        [JsonIgnore]
        public bool IsPinned => Pinned == 1;

        [JsonIgnore]
        public bool IsPublished => Published == 1;
    }
}
