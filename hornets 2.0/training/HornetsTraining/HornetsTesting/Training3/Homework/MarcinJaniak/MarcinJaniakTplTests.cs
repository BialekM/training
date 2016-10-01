using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.MarcinJaniak;

namespace HornetsTesting.Training3.Homework.MarcinJaniak
{
    [TestClass]
    public class MarcinJaniakTplTests
    {

        [TestMethod]
        public void TestOneThread()
        {
            var mjTPL1T = new MarcinJaniakTplHomeworkOneThread();

            mjTPL1T.DoTransfers();

        }

        [TestMethod]
        public void TestMultiThread()
        {
            var mjTPLMT = new MarcinJaniakTplHomeworkMultiThread();

            mjTPLMT.DoTransfers();

        }

    }
}