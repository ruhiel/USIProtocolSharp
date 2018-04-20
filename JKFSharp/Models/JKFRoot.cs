using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharpp.Models
{
    public class JKFRoot
    {
        [JsonProperty("header")]
        public Player Player { get; set; }

        [JsonProperty("moves")]
        public List<Record> Record {get;set;}

        [JsonProperty("initial")]
        public Initial Initial { get; set; }
    }
}
