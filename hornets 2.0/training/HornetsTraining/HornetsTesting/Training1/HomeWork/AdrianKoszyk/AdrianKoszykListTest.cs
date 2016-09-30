using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.AdrianKoszyk
{
    [TestClass]
    public class AdrianKoszykListTest
    {
        private  AdrianKoszykList<int> AdrKoszListTestInt =new AdrianKoszykList<int>();
        private  AdrianKoszykList<string> AdrKoszListTestString =new AdrianKoszykList<string>();

       [TestMethod]
        public void AddTestStringAndInt()
        {
            AdrKoszListTestInt.Add(4);
            AdrKoszListTestInt.Add(5);
            Assert.AreEqual(AdrKoszListTestInt.GetElement(0),4);
            Assert.AreEqual(AdrKoszListTestInt.GetElement(1), 5);

            AdrKoszListTestString.Add("Pierwszy");
            AdrKoszListTestString.Add("Drugi");
            Assert.AreEqual(AdrKoszListTestString.GetElement(0), "Pierwszy");
            Assert.AreEqual(AdrKoszListTestString.GetElement(1), "Drugi");

        }
    }
}