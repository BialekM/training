using HornetsTraining.Training1.HomeWork.ArnoldNowak;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Toci.HornetsTraining.Training1.HomeWork.ArnoldNowak;

namespace HornetsTesting.Training1.Homework.ArnoldNowak
{
    [TestClass]
    public class ArnoldNowakStringOperationsUnitTest
    {
        private readonly ArnoldNowakStringOperations testInstance= new ArnoldNowakStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(testInstance.GetName(), "Arnold Nowak");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(testInstance.Substring("Bartek Zapart", 7, 6), "Zapart");
            Assert.AreEqual(testInstance.Substring("beatka", 1, 3), "eat");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(testInstance.PositionInString("bartek", "rte"), 2);
            Assert.AreEqual(testInstance.PositionInString("bartek", "rta"), -1);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(testInstance.StringReplace("Bartek Zapart", "Nowak", "Zapart"), "błąd");
            Assert.AreEqual(testInstance.StringReplace("Arnold Nowak", "Nowak", "Kowalski"), "Arnold Kowalski");
        }
    }
}