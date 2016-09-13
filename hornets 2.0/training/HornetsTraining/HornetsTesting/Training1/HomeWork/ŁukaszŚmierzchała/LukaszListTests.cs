using Microsoft.VisualStudio.TestTools.UnitTesting;
using HornetsTraining.Training1.HomeWork.ŁukaszŚmierzchała;

namespace HornetsTesting.Training1.HomeWork.ŁukaszŚmierzchała
{
    [TestClass]
    public class LukaszListTests
    {

        [TestMethod]
        public void AddTest()
        {
            var testList = new LukaszList<string>();

            string item0 = "hahah";
            string item1 = "tralal";
            string item2 = "idontknow";
            string item3 = "lalala";

            testList.Add(item0);
            testList.Add(item1);
            testList.Add(item2);
            testList.Add(item3);

            Assert.AreEqual("hahah", item0);

            Assert.AreEqual(item0, testList[0]);
            Assert.AreEqual(item1, testList[1]);
            Assert.AreEqual(item2, testList[2]);
            Assert.AreEqual(item3, testList[3]);
        }
    }
}
