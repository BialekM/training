using Toci.HornetsTraining.Training1.HomeWork.WojtekSabat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.WojtekSabat
{
    [TestClass]
    public class WojtekSabatStringOperationsTest
    {
        WojtekSabatStringOperations stringOperations = new WojtekSabatStringOperations();

        [TestMethod]
        public void SubstringTest()
        {
            const string candidate = "beatka",substring="eat";
            const int start = 1, length = 3;
            Assert.AreEqual(substring,stringOperations.Substring(candidate, start, length));
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            const string candidate = "czestochowa", needle = "chowa";
            const int position = 6;
            Assert.AreEqual(position,stringOperations.PositionInString(candidate, needle));
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            const string candidate = "baran", needle = "an", newNeedle = "tek", newString="bartek";

            Assert.AreEqual(newString,stringOperations.StringReplace(candidate, needle, newNeedle));
        }
    }
}