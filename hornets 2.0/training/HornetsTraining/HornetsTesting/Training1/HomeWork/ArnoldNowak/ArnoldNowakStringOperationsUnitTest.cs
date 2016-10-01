using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.ArnoldNowak;

namespace HornetsTesting.Training1.Homework.ArnoldNowak
{
    [TestClass]
    public class ArnoldNowakStringOperationsUnitTest
    {
        private readonly ArnoldNowakStringOperations _testInstance= new ArnoldNowakStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_testInstance.GetName(), "Arnold Nowak");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_testInstance.Substring("Bartek Zapart", 7, 6), "Zapart");
            Assert.AreEqual(_testInstance.Substring("beatka", 1, 3), "eat");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_testInstance.PositionInString("bartek", "rte"), 2);
            Assert.AreEqual(_testInstance.PositionInString("bartek", "rta"), -1);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_testInstance.StringReplace("Bartek Zapart", "Nowak", "Zapart"), "błąd");
            Assert.AreEqual(_testInstance.StringReplace("Arnold Nowak", "Nowak", "Kowalski"), "Arnold Kowalski");
        }
    }
}