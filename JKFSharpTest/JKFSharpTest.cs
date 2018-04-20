using System;
using JKFSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JKFSharpTest
{
    [TestClass]
    public class JKFSharpTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var json = @"{
              ""header"": {},
              ""moves"": [
                {""comments"":[""分岐の例""]},
                {""move"":{""from"":{""x"":7,""y"":7},""to"":{""x"":7,""y"":6},""color"":0,""piece"":""FU""}},
                {""move"":{""from"":{""x"":3,""y"":3},""to"":{""x"":3,""y"":4},""color"":1,""piece"":""FU""}, ""comments"":[""次の手で二種類が考えられる：７七桂か２二角成である．"",""２二角成を選ぶと筋違い角となる．""]},
                {""move"":{""from"":{""x"":8,""y"":9},""to"":{""x"":7,""y"":7},""color"":0,""piece"":""KE""}, ""forks"":[
                  [
                    {""move"":{""from"":{""x"":8,""y"":8},""to"":{""x"":2,""y"":2},""color"":0,""piece"":""KA"",""capture"":""KA"",""promote"":false}},
                    {""move"":{""from"":{""x"":3,""y"":1},""to"":{""x"":2,""y"":2},""color"":1,""piece"":""GI"",""capture"":""KA"",""same"":true}},
                    {""move"":{""to"":{""x"":4,""y"":5},""color"":0,""piece"":""KA""}}
                  ]
                ]},
                {""move"":{""from"":{""x"":2,""y"":2},""to"":{""x"":7,""y"":7},""color"":1,""piece"":""KA"",""capture"":""KE"",""promote"":true,""same"":true}},
                {""move"":{""from"":{""x"":8,""y"":8},""to"":{""x"":7,""y"":7},""color"":0,""piece"":""KA"",""capture"":""UM"",""same"":true}},
                {""move"":{""to"":{""x"":3,""y"":3},""color"":1,""piece"":""KE"",""relative"":""H""}}
              ]}";

            var parser = new JKFParser();

            parser.Test1(json);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var json = @"{
              ""header"": {},
              ""initial"": {""preset"": ""6""},
              ""moves"": [
                {},
                {""move"":{""from"":{""x"":5,""y"":1},""to"":{""x"":4,""y"":2},""color"":1,""piece"":""OU""}},
                {""move"":{""from"":{""x"":7,""y"":7},""to"":{""x"":7,""y"":6},""color"":0,""piece"":""FU""}},
                {""move"":{""from"":{""x"":6,""y"":1},""to"":{""x"":7,""y"":2},""color"":1,""piece"":""KI""}}
              ]
            }";

            var parser = new JKFParser();

            parser.Test1(json);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var json = @"{
              ""header"": {},
              ""initial"": {
                ""preset"": ""OTHER"",
                ""data"": {
                  ""board"": [
                    [{""color"":1, ""kind"":""KY""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""KY""}],
                    [{""color"":1, ""kind"":""KE""}, {""color"":1, ""kind"":""KA""},{""color"":1, ""kind"":""FU""}, {}, {}, {}, {                      }, {""color"":0, ""kind"":""HI""}, {""color"":0, ""kind"":""KE""}],
                    [{""color"":1, ""kind"":""GI""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""GI""}],
                    [{""color"":1, ""kind"":""KI""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""KI""}],
                    [{""color"":1, ""kind"":""OU""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""OU""}],
                    [{""color"":1, ""kind"":""KI""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""KI""}],
                    [{""color"":1, ""kind"":""GI""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {                      }, {                      }, {""color"":0, ""kind"":""GI""}],
                    [{""color"":1, ""kind"":""KE""}, {""color"":1, ""kind"":""HI""},{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {""color"":0, ""kind"":""KA""}, {""color"":0, ""kind"":""KE""}],
                    [{""color"":1, ""kind"":""KY""}, {                      },{""color"":1, ""kind"":""FU""}, {}, {}, {}, {""color"":0, ""kind"":""FU""}, {                      }, {""color"":0, ""kind"":""KY""}]
                  ],
                  ""color"": 0,
                  ""hands"":[
                    {""FU"":0,""KY"":0,""KE"":0,""GI"":0,""KI"":0,""KA"":0,""HI"":0},
                    {""FU"":0,""KY"":0,""KE"":0,""GI"":0,""KI"":0,""KA"":0,""HI"":0}
                  ]
                }
              },
              ""moves"": [
                {""comments"": [""飛車角先落ち．""]},
                {""move"":{""from"":{""x"":2,""y"":8},""to"":{""x"":2,""y"":3},""color"":0,""piece"":""HI"",""promote"":true,""capture"":""FU""}}
              ]
            }";

            var parser = new JKFParser();

            parser.Test1(json);
        }
    }
}
