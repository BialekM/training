using HornetsTraining.Training2.Delegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.Delegates
{
    [TestClass]
    public class DelegateExampleTest
    {
        [TestMethod]
        public void TestDelegates()
        {
            DelegateExample example = new DelegateExample();


            example.TestPositionInStringByAll();
        }
    }
}