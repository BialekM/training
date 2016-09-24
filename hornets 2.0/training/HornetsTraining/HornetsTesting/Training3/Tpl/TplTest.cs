using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Tpl;

namespace HornetsTesting.Training3.Tpl
{
    [TestClass]
    public class TplTest
    {
        [TestMethod]
        public void ParalelismTest()
        {
            Paralelism p = new Paralelism();

            p.CreateMultiTaskFileSave();
        }
    }
}