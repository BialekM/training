using HornetsTraining.Training2.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class PlusBankTransferTest
    {
        [TestMethod]
        public void TestTransfers()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "101680436763276523475234", SourceBankAccount = "101680437285943", Money = 250};

            PlusBankTransferResolver res = new PlusBankTransferResolver();
            res.DoTransfer(transfer);
          
        }
    }
}