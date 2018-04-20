using JKFSharp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharpp.Models
{
    public class Initial
    {
        [JsonProperty("preset")]
        public string Preset { get; set; }

        [JsonProperty("data")]
        public InitialData Data { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("hands")]
        public Hand[] Hands { get; set; }
    }
}
