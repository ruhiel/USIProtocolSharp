using JKFSharpp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utf8Json;

namespace JKFSharp
{
    public class JKFParser
    {
        public void Test1(string json)
        {
            var jkf = JsonConvert.DeserializeObject<JKFRoot>(json);

            Debug.WriteLine(jkf);
        }
    }
}
