using System.Diagnostics;
using Toci.HornetsTraining.Training1.HomeWork.SlawekKowal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.SlawekKowal
{
    [TestClass]
    public class SlawekKListTest
    {
        [TestMethod]
        public void TestList()
        {
            SlawekKMyList<int> numbers = new SlawekKMyList<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Assert.AreEqual(numbers.GetItem(0), 1);
            Assert.AreEqual(numbers.GetItem(1), 2);
            Assert.AreEqual(numbers.GetItem(2), 3);

            SlawekKMyList<string> text = new SlawekKMyList<string>();

            text.Add("dupa");
            text.Add("jaś");
            text.Add("hej");


            Assert.AreEqual(text.GetItem(0), "dupa");
            Assert.AreEqual(text.GetItem(1), "jaś");
            Assert.AreEqual(text.GetItem(2), "hej");
            Debug.WriteLine("sdfsdfsd" + text.GetItem(0));
        }
    }
}