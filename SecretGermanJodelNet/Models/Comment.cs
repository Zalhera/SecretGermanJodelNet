using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Comment
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

#warning TODO: Find out what this is
        [JsonPropertyName("approvals")]
        public List<object> Approvals { get; set; } = new List<object>();

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("imageA")]
        public string? ImageA { get; set; }

        [JsonPropertyName("video")]
        public string? Video { get; set; }

        [JsonPropertyName("text")]
        public string? Text { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("votes")]
        public Votes Votes { get; set; } = default!;

        [JsonPropertyName("author")]
        public Author Author { get; set; } = default!;

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("pinned")]
        public int Pinned { get; set; }

        [JsonPropertyName("published")]
        public int Published { get; set; }

        [JsonPropertyName("report")]
        public int Report { get; set; }

        [JsonPropertyName("user_published")]
        public int UserPublished { get; set; }

        [JsonPropertyName("approval")]
        public int Approval { get; set; }

        [JsonPropertyName("additional_information")]
        public string AdditionalInformation { get; set; } = string.Empty;

        [JsonIgnore]
        public bool IsImage => !string.IsNullOrEmpty(Image);

        [JsonIgnore]
        public bool IsGif => !string.IsNullOrEmpty(ImageA);

        [JsonIgnore]
        public bool IsVideo => !string.IsNullOrEmpty(Video);

        [JsonIgnore]
        public bool IsText => !string.IsNullOrEmpty(Text);

        [JsonIgnore]
        public bool IsPinned => Pinned == 1;

        [JsonIgnore]
        public bool IsPublished => Published == 1;
    }
}
