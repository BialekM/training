using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.SlawekKowal;

namespace Toci.SeeSharpBasics.Test.SlawekKowal
{
    [TestClass]
    public class SlawekStringOperationTest
    {
        [TestMethod]
        public void TestMyStrings()
        {
            
            SlawekKStringOperations myTest = new SlawekKStringOperations();
            var test = myTest.GlueBeginingEnd("kafar");
            Assert.AreEqual(test,"kraaf");

        }
    }
}