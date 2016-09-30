using Toci.HornetsTraining.Training1.HomeWork.LukaszPopiolek;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.LukaszPopiolek
{
    [TestClass]
    public class LukaszPopiolekListTests
    {
        [TestMethod]
        public void AddTest()
        {
            LukaszPopiolekList<int> IntList = new LukaszPopiolekList<int>();
            IntList.Add(32);
            IntList.Add(1);
            IntList.Add(0);
            IntList.Add(5);
            Assert.AreEqual(IntList.GetElement(0), 32);
            Assert.AreEqual(IntList.GetElement(1), 1);
            Assert.AreEqual(IntList.GetElement(2), 0);
            Assert.AreEqual(IntList.GetElement(3), 5);
            Assert.AreEqual(IntList.GetElement(3312312), 0);
            LukaszPopiolekList<string> StringList = new LukaszPopiolekList<string>();
            StringList.Add("test");
            StringList.Add("");
            StringList.Add("QWERTY");
            Assert.AreEqual(StringList.GetElement(0),"test");
            Assert.AreEqual(StringList.GetElement(1),"");
            Assert.AreEqual(StringList.GetElement(2),"QWERTY");
            Assert.AreEqual(StringList.GetElement(123),null);

        }
    }
}