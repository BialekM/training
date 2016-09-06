
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics;
using SeeSharpBasics.AdrianPankiewicz;

namespace SeeSharpBasicsTest.AdrianPankiewiczTest
{
    [TestClass]
    public class AdrianPankiewiczStringOperationsTest
    {
        private readonly StringOperations _adrPanStrOpr = new AdrianPankiewiczStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual("Adrian Pankiewicz", _adrPanStrOpr.GetName());
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual("Basics", _adrPanStrOpr.Substring("C#BasicsString", 2, 6));
        }

        [TestMethod]
        public void CountOccurencesTest()
        {
            Assert.AreEqual(3, _adrPanStrOpr.CountOccurences("anakonda", 'a'));
        }

        [TestMethod]
        public void LetterPositionInStringTest()
        {
            Assert.AreEqual(3 , _adrPanStrOpr.LetterPositionInString("jajko", 'k'));
        }

        [TestMethod]
        public void LetterReplaceTest()
        {
            Assert.AreEqual("pwogwamista", _adrPanStrOpr.LetterReplace("programista", 'r', 'w'));
        }
    }
}