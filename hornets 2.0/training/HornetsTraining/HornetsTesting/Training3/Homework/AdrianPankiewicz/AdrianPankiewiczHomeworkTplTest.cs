using Toci.HornetsTraining.Training3.Homework.AdrianPankiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework.AdrianPankiewicz
{
    [TestClass]
    public class AdrianPankiewiczHomeworkTplTest
    {
        [TestMethod]
        public void TplTest()
        {
            AdrianPankiewiczTplHomeWork tplHomework = new AdrianPankiewiczTplHomeWork();
            tplHomework.DoTransfers();
        }
    }
}