using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class JodelResponse
    {
        [JsonPropertyName("view")]
        public View View { get; set; }

        [JsonPropertyName("jodels")]
        public List<Jodel> Jodels { get; set; }
    }
}
