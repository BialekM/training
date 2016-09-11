using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.HomeWork.LukaszPopiolek;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.LukaszPopiolek
{
    [TestClass]
    class LukaszPopiolekStringOperationsTests
    {
        LukaszPopiolekStringOperations so = new LukaszPopiolekStringOperations();
        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(so.Substring("beatka", 1, 3), "eat");
            Assert.AreEqual(so.Substring("beatka", 0, 6), "beatka");
            Assert.AreEqual(so.Substring("beatka", 0, 3000), "beatka");
        }

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(so.GetName(), "Lukasz Popiolek");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(so.PositionInString("testowy", "owy"), 4);
            Assert.AreEqual(so.PositionInString("testowy", "towy"), 3);
            Assert.AreEqual(so.PositionInString("testowy", "testowy"), 0);
            Assert.AreEqual(so.PositionInString("testowy", "testowysd"), -1);
            Assert.AreEqual(so.PositionInString("testowy", "tesxowys"), -1);
            Assert.AreEqual(so.PositionInString("testowy", "xestowy"), -1);
            Assert.AreEqual(so.PositionInString("xdtestowy", "testowy"), 2);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(so.StringReplace("tatoto", "to", "ma"), "tamama");
            Assert.AreEqual(so.StringReplace("tatoto", "to", "max"), "tamaxmax");
            Assert.AreEqual(so.StringReplace("tatoto", "to", "to"), "tatoto");
            Assert.AreEqual(so.StringReplace("tatoto", "to", "toto"), "tatotototo");
            Assert.AreEqual(so.StringReplace("beata", "at", "atk"), "beatka");
        }
    }
}
