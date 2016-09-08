using System;
using HornetsTraining.Training1.HomeWork.ŁukaszŚmierzchała;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.ŁukaszŚmierzchała
{
    [TestClass]
    public class StringOperationsTests
    {
        private readonly LukaszSmierzchalaStringOperations _stringOperations = new LukaszSmierzchalaStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            string name = "Łukasz Śmierzchała";

            Assert.AreEqual(name, _stringOperations.GetName());
        }

        [TestMethod]       
        public void SubstringTest()
        {
            string candidate = "OhMyGod";
            string substring = "hMy";
            int start = 1;
            int length = 3;

            Assert.AreEqual(substring, _stringOperations.Substring(candidate, start, length));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SubstringExTest()
        {
            string candidate = "OhMyGod";
            int start = 0;
            int length = 8;
            
            _stringOperations.Substring(candidate, start, length);
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            string candidate = "OhMyGod";
            string needle = "hMy";
            int position = 1;

            Assert.AreEqual(position, _stringOperations.PositionInString(candidate, needle));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PositionInStringExTest()
        {
            string candidate = "OhMyGod";
            string needle = "god";

            _stringOperations.PositionInString(candidate, needle);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            string candidate = "OhMyGod";
            string needle = "hMy";
            string replaceWith = "You";
            string result = "OYouGod";

            Assert.AreEqual(result, _stringOperations.StringReplace(candidate, needle, replaceWith));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringReplaceExTest()
        {
            string candidate = "OhMyGod";
            string needle = "god";
            string replaceWith = "NeverMind";

            _stringOperations.StringReplace(candidate, needle, replaceWith);
        }
    }
}
