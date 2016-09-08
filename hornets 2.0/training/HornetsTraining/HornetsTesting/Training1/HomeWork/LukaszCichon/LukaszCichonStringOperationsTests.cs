using HornetsTraining.Training1.HomeWork.LukaszCichon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.LukaszCichon
{
    [TestClass]
    public class LukaszCichonStringOperationsTests
    {
        private readonly LukaszCichonStringOperations _lcStrOpr = new LukaszCichonStringOperations();


        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_lcStrOpr.GetName(), "Lukasz Cichon");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_lcStrOpr.Substring("Beata", 1, 3), "eat");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_lcStrOpr.PositionInString("Beata", "ata"), 2);
            Assert.AreEqual(_lcStrOpr.PositionInString("Beata", "ea"), 1);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_lcStrOpr.StringReplace("Beata", "at", "atk"), "Beatka");
            Assert.AreEqual(_lcStrOpr.StringReplace("Hubert", "t", "cik"), "Hubercik");
            Assert.AreEqual(_lcStrOpr.StringReplace("Beata", "Beat", "Armat"), "Armata");
        }
    }
}