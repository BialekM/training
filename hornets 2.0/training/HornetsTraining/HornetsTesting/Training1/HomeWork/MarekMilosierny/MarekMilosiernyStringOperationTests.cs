using Toci.HornetsTraining.Training1.HomeWork.MarekMilosierny;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MarekMilosierny
{
    [TestClass]
    public class MarekMilosiernyStringOperationTests
    {
        readonly MarekMilosiernyStringOperation _stringOperationTestObject = new MarekMilosiernyStringOperation();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("Marek Miłosierny", _stringOperationTestObject.GetName());
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual("atk", _stringOperationTestObject.Substring("beatka", 2, 3));
            Assert.AreEqual("rek", _stringOperationTestObject.Substring("marek", 2, 3));
            Assert.AreEqual("k", _stringOperationTestObject.Substring("kaczka", 0, 1));
            Assert.AreEqual(" ma", _stringOperationTestObject.Substring("Ala ma kota", 3, 3));
            Assert.AreEqual("", _stringOperationTestObject.Substring("radek", 0, 0));
            Assert.AreEqual("", _stringOperationTestObject.Substring("", 0, 1));
            Assert.AreEqual("", _stringOperationTestObject.Substring("text", -1, 3));
            Assert.AreEqual("", _stringOperationTestObject.Substring("text", 2, 8));
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(3, _stringOperationTestObject.PositionInString("beatka", "tka"));
            Assert.AreEqual(0, _stringOperationTestObject.PositionInString("beatka", "b"));
            Assert.AreEqual(0, _stringOperationTestObject.PositionInString("kukurydza", "ku"));
            Assert.AreEqual(-1, _stringOperationTestObject.PositionInString("beatka", "woda"));
            Assert.AreEqual(4, _stringOperationTestObject.PositionInString("marek", "k"));
            Assert.AreEqual(-1, _stringOperationTestObject.PositionInString("beatka", ""));
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual("beatka", _stringOperationTestObject.StringReplace("beata", "ta", "tka"));
            Assert.AreEqual("ala ma jeża", _stringOperationTestObject.StringReplace("ala ma kota", "kota", "jeża"));
            Assert.AreEqual("3214532145321", _stringOperationTestObject.StringReplace("1234512345123", "123", "321"));
            Assert.AreEqual("blebleble", _stringOperationTestObject.StringReplace("blablabla", "bla", "ble"));
        }
    }
}
