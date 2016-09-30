using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.PawelKownacki;

namespace HornetsTesting.Training3.Homework.PawelKownacki
{
    [TestClass]
    public class PawelKownackiTplHomeworkTest
    {
        [TestMethod]
        public void TplTest()
        {
            PawelKownackiTplHomework tplHomeworkTest = new PawelKownackiTplHomework();
            tplHomeworkTest.DoTransfers();
        }
    }
}