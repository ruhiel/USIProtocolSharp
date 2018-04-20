using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKFSharp.Models
{
    public class Piece
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }


        [JsonProperty("color")]
        public int? Color { get; set; }
    }
}
