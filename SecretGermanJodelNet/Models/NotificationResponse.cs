using System.Text.Json.Serialization;

namespace SecretGermanJodelNet.Models
{
    public class NotificationResponse
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("notifications")]
        public List<Notification> Notifications { get; set; } = new List<Notification>();
    }
}
