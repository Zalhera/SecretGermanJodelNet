using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class View
    {
        [JsonPropertyName("main")]
        public int Main { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
