
using System;
using System.Security.Cryptography;
using Toci.HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class AdrianPankiewiczListTest
    {
        
        [TestMethod]
        public void AddTest1()
        {
            AdrianPankiewiczList<int> itemList = new AdrianPankiewiczList<int>();

            Random random = new Random();
            for (int i = 0; i < 1000; i++)
                itemList.Add(random.Next(1, 101));
        }

        [TestMethod]
        public void AddTest2()
        {
            AdrianPankiewiczList<int> itemList = new AdrianPankiewiczList<int>();

            for (int i = 0; i < 10; i++)
                itemList.Add(i);

            for (int i = 0; i < 10; i++)
                Assert.AreEqual(i, itemList.GetElement(i));
        }

        [TestMethod]
        public void EmptyTest()
        {
            AdrianPankiewiczList<int> itemList = new AdrianPankiewiczList<int>();

            Assert.IsTrue(itemList.Empty());
            itemList.Add(1020);
            Assert.IsFalse(itemList.Empty());
        }
    }
}