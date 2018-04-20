using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharpp.Models
{
    public class Record
    {
        [JsonProperty("move")]
        public Move Move { get; set; }

        [JsonProperty("special")]
        public string Special { get; set; }
    }
}
