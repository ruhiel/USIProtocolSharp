using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharpp.Models
{
    public class Move
    {
        [JsonProperty("from")]
        public Location From { get; set; }

        [JsonProperty("to")]
        public Location To { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("piece")]
        public string Piece { get; set; }

        [JsonProperty("capture")]
        public string Capture { get; set; }

        [JsonProperty("promote")]
        public bool Promote { get; set; }

        [JsonProperty("same")]
        public bool Same { get; set; }

        [JsonProperty("comments")]
        public List<string> Comments { get; set; }

        [JsonProperty("forks")]
        public List<Move> Forks { get; set; }
    }
}
