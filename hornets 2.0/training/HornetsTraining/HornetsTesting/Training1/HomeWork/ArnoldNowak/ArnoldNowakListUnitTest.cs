using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.ArnoldNowak;

namespace HornetsTesting.Training1.Homework.ArnoldNowak
{
    [TestClass]
    public class ArnoldNowakListUnitTest
    {
        private readonly ArnoldNowakList<int> _testInstance = new ArnoldNowakList<int>();

        [TestMethod]
        public void AddTest()
        {
            int number = 999;
            _testInstance.Add(number);
            _testInstance.Add(number+1);
            Assert.AreEqual(_testInstance.GetElement(0), 999);
            Assert.AreEqual(_testInstance.GetElement(1), 1000);
        }
    }
}