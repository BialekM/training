using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.LukaszCichon;

namespace HornetsTesting.Training3.Homework.LukaszCichon
{
    [TestClass]
    public class LukaszCichonHomeworkTplTest
    {
        [TestMethod]
        public void testTpl()
        {
            LukaszCichonTplHomework tpl = new LukaszCichonTplHomework();

            tpl.DoTransfers();
        }
         
    }
}