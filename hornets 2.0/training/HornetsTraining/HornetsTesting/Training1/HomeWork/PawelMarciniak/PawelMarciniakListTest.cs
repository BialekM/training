using Microsoft.VisualStudio.TestTools.UnitTesting;
using HornetsTraining.Training1.HomeWork.PawelMarciniak;

namespace HornetsTesting.Training1.Homework.PawelMarciniak
{
    [TestClass]
    public class PawelMarciniakListTest
    {
        [TestMethod]
        public void AddTest()
        {
            PawelMarciniakMyList<int> myList = new PawelMarciniakMyList<int>();

            for (int i = 0; i < 50; i++)
            {
                myList.Add(i);
            }

            PawelMarciniakMyList<string> myStringList = new PawelMarciniakMyList<string>();
            myStringList.Add("test1");
            myStringList.Add("test2");
            myStringList.Add("testing");
            Assert.AreEqual(myStringList.GetElem(0), "test1");
            Assert.AreEqual(myStringList.GetElem(2), "test2");
            Assert.AreEqual(myStringList.GetElem(3), "testing");
        }

    }
}