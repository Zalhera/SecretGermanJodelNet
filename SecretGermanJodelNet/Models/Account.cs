using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record Account
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        [JsonPropertyName("hoehepunkte")]
        public string Hoehepunkte { get; set; } = "0";

        [JsonPropertyName("feels")]
        public Feels Feels { get; set; } = default!;

        [JsonPropertyName("gender")]
        public Gender Gender { get; set; } = default!;

        [JsonPropertyName("notifications")]
        public Notifications Notifications { get; set; } = default!;

        [JsonPropertyName("premium")]
        public Premium Premium { get; set; } = default!;

        [JsonPropertyName("donator")]
        public Donator Donator { get; set; } = default!;

        [JsonPropertyName("verification")]
        public int Verification { get; set; }

        [JsonPropertyName("mod")]
        public int Mod { get; set; }

        [JsonPropertyName("ro")]
        public int Ro { get; set; }

        [JsonPropertyName("settings")]
        public AccountSettings Settings { get; set; } = default!;

        [JsonPropertyName("entrycodes")]
        public Entrycodes Entrycodes { get; set; } = default!;

        [JsonPropertyName("location")]
        public int Location { get; set; }
    }
}
