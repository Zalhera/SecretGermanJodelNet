﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SecretGermanJodelNet.Models.Jodel
{
    public class UserMessages
    {
        [JsonPropertyName("all")]
        public int All { get; set; }
    }
}
