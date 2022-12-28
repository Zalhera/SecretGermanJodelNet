using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public record JodelResponseBase<T> where T : class
    {
        [JsonPropertyName("status_id")]
        public int StatusId { get; set; }
        [JsonPropertyName("results")]
        public T? Result { get; set; }
    }
}
