using HornetsTraining.Training1.HomeWork.WojtekSabat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.WojtekSabat
{
    [TestClass]
    public class WojtekSabatListTest
    {
        WojtekSabatList<int> myList = new WojtekSabatList<int>();

        [TestMethod]
        public void AddTest()
        {
            Assert.AreEqual(myList.Length,0);
            myList.Add(3);
            Assert.AreEqual(myList.Length,1);
            myList.Add(2);
            Assert.AreEqual(myList.Length,2);
            myList.Add(8);
            Assert.AreEqual(myList.Length,3);
            
        }
    }
}