using HornetsTraining.Training3.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Linq
{

    [TestClass]
    public class LinqTest
    {
        [TestMethod]
        public void TestSelect()
        {
            WhereExample example = new WhereExample();

            example.LinqSelectShowDown();
        }
    }
}