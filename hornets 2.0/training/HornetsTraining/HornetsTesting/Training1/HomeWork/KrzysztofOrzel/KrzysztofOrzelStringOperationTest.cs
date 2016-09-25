using HornetsTraining.Training1.HomeWork.KrzysztofOrzel;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.KrzysztofOrzel
{
    public class KrzysztofOrzelStringOperationTest
    {
        public KrzysztofOrzelStringOperation stringOperation = new KrzysztofOrzelStringOperation();

        [TestMethod]

        public void GetNameTest()
        {
            Assert.AreEqual(stringOperation.GetName(), "Krzysztof Orzel");
        }

        [TestMethod]

        public void SubstringTest()
        {
            Assert.AreEqual(stringOperation.Substring(stringOperation.GetName(), 6, 3), "tof");
        }

        [TestMethod]

        public void PositionInStringTest()
        {
            Assert.AreEqual(stringOperation.PositionInString(stringOperation.GetName(), "rzy"), 2);
        }

        [TestMethod]

        public void StringReplaceTest()
        {
            Assert.AreEqual(stringOperation.StringReplace(stringOperation.GetName(), "sztof", "siu"), "Krzysiu Orzel");
        }

        
    }
}