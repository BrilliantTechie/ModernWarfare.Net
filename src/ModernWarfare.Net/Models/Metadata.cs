﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models
{
    public class Metadata
    {
        [JsonProperty("iconUrl")]
        public Uri IconUrl { get; set; }
    }
}
