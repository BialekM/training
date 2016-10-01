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
            string result = test.GetBankCodeForAccount("124124124124"); // test -zwraca 4 cyfry z numeru konta

            string result2 = test.GetBankName("1020"); // zwraca nazwę banku dla kodu

            EdwinPeselValidator peselVal = new EdwinPeselValidator();
            bool peselValid = peselVal.IsPeselValid("84080818074");
            
        }
    }
}