using HornetsTraining.Training1.HomeWork.KrzysztofPater;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.KrzysztofPater
{
    [TestClass]
    public class KrzysztofPaterStringOperationsTest
    {
        private KrzysztofPaterStringOperations kPaterStringOperations = new KrzysztofPaterStringOperations();

        [TestMethod]

        public void GetNameTest()
        {
            Assert.AreEqual(kPaterStringOperations.GetName(), "Krzysztof Pater");
        }

        [TestMethod]

        public void SubstringTest()
        {
            Assert.AreEqual(kPaterStringOperations.Substring(kPaterStringOperations.GetName(), 3, 4), "yszt");
        }

        [TestMethod]

        public void PositionInStringTest()
        {
            Assert.AreEqual(kPaterStringOperations.PositionInString(kPaterStringOperations.GetName(), "ate"), 11);
        }

        [TestMethod]

        public void StringReplaceTest()
        {
            Assert.AreEqual(kPaterStringOperations.StringReplace(kPaterStringOperations.GetName(), "ztof", "iek"), "Krzysiek Pater");
        }

        [TestMethod]

        public void StringReplaceTest2()
        {
            Assert.AreEqual(kPaterStringOperations.StringReplace(kPaterStringOperations.GetName(), "t", "d"), "Krzyszdof Pader");
        }
    }
}