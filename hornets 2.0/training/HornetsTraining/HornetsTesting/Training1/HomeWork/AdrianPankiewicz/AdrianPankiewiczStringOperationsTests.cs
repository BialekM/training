using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class AdrianPankiewiczStringOperationsTest
    {
        private readonly AdrianPankiewiczStringOperations _adrPanStrOpr = new AdrianPankiewiczStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_adrPanStrOpr.GetName(), "Adrian Pankiewicz");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_adrPanStrOpr.Substring("C#BasicsString", 2, 6), "Basics");
            Assert.AreEqual(_adrPanStrOpr.Substring("beatka", 1, 3), "eat");
            Assert.AreEqual(_adrPanStrOpr.Substring("bartek", 2, 4), "rtek");
        }

        [TestMethod]
        public void GlueBeginningEndTest()
        {
            Assert.AreEqual(_adrPanStrOpr.GlueBeginingEnd("bartlomiej"), "bjaeritmlo");
        }

        [TestMethod]
        public void CountOccurencesTest()
        {
            Assert.AreEqual(_adrPanStrOpr.CountOccurences("anakonda", 'a'), 3);
            Assert.AreEqual(_adrPanStrOpr.CountOccurences("bartek", 'a'), 1);
            Assert.AreEqual(_adrPanStrOpr.CountOccurences("beatka", 'a'), 2);
            Assert.AreEqual(_adrPanStrOpr.CountOccurences("aaaaba", 'a'), 5);
        }

        [TestMethod]
        public void LetterPositionInStringTest()
        {
            Assert.AreEqual(_adrPanStrOpr.LetterPositionInString("jajko", 'k'), 3);
            Assert.AreEqual(_adrPanStrOpr.LetterPositionInString("bartek", 'k'), 5);
        }

        [TestMethod]
        public void LetterReplaceTest()
        {
            Assert.AreEqual(_adrPanStrOpr.LetterReplace("programista", 'r', 'w'), "pwogwamista");
            Assert.AreEqual(_adrPanStrOpr.LetterReplace("beatka", 'e', 's'), "bsatka");
            Assert.AreEqual(_adrPanStrOpr.LetterReplace("beatka", 'a', 'b'), "bebtkb");
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_adrPanStrOpr.StringReplace("bartlomiej", "art", "beatka"), "bbeatkalomiej");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_adrPanStrOpr.PositionInString("bartlomiej", "art"), 1);
        }
    }
}