using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharp.Models
{
    public class Hand
    {
        [JsonProperty("FU")]
        public int? FU { get; set; }
        [JsonProperty("KY")]
        public int? KY { get; set; }
        [JsonProperty("KE")]
        public int? KE { get; set; }
        [JsonProperty("GI")]
        public int? GI { get; set; }
        [JsonProperty("KI")]
        public int? KI { get; set; }
        [JsonProperty("KA")]
        public int? KA { get; set; }
        [JsonProperty("HI")]
        public int? HI { get; set; }
    }
}
