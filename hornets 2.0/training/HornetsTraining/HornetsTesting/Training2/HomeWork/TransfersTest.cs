using HornetsTraining.Training2.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class TransfersTest
    {
        [TestMethod]
        public void TestTransfers()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "101020436763276523475234", SourceBankAccount = "101050437285943", Money = 250};

            TransferHandler thd = new MbankTransferHandler();

            thd.DoInTransfer(transfer);
        }
    }
}