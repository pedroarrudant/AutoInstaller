using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AI.Domain
{
    public class Software
    {
        [JsonProperty("nome")]
        public string Name { get; set; }

        [JsonProperty("caminhoweb")]
        public string WebPath { get; set; }

        [JsonProperty("nomearquivo")]
        public string FileName { get; set; }

        [JsonProperty("formasileciosa")]
        public string Silent { get; set; }
    }
}
