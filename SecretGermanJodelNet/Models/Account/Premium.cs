﻿using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models.Account
{
    public record Premium
    {
        [JsonPropertyName("active")]
        public int Active { get; set; }

        [JsonPropertyName("valid")]
        public string Valid { get; set; } = string.Empty;
    }
}
