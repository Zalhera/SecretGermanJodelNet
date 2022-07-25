using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Models
{
    public abstract class JodelResponseBase<T> where T : class
    {
        [JsonPropertyName("status_id")]
        public int StatusId { get; set; }
        [JsonPropertyName("results")]
        public T Result { get; set; }
    }
}
