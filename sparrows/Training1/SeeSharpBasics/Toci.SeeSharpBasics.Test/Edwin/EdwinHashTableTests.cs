using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Edwin.HomeWorkHashTables;

namespace Toci.SeeSharpBasics.Test.Edwin
{
    [TestClass]
    public class EdwinHashTableTests
    {
        [TestMethod]
        public void TestM()
        {
            EdwinBankResolver test = new EdwinBankResolver();
            string result = test.GetBankCodeForAccount("124124124124");

            string result2 = test.GetBankName("1140");
        }
    }
}