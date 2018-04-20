using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using USIProtocolSharp;

namespace USIProtocolSharpTest
{
    [TestClass]
    public class USIProtocolSharpTest
    {
        private USIProtocol c = new USIProtocol();
        private bool flag = true;

        [TestMethod]
        public void TestMethod1()
        {
            c.OnUSIOkEvent += C_OnUSIOkEvent;

            c.USI();

            while(flag)
            {

            }
        }

        private void C_OnUSIOkEvent()
        {
            c.Quit();

            flag = false;
        }
    }
}
