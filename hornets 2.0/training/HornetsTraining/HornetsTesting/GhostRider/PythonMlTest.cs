using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.GhostRider.DLR;

namespace HornetsTesting.GhostRider
{
    [TestClass]
    public class PythonMlTest
    {
        [TestMethod]
        public void Test()
        {
            PythonMl ml = new PythonMl();

            ml.Test();
        }
    }
}