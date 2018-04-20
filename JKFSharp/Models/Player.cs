using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharpp.Models
{
    public class Player
    {
        [JsonProperty("先手")]
        public string Black { get; set; }

        [JsonProperty("後手")]
        public string White { get; set; }
    }
}
