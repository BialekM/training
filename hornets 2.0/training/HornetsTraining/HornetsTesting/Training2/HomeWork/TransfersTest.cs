using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class TransfersTest
    {
        [TestMethod]
        public void TestTransfers()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "101020436763276523475234", SourceBankAccount = "101020436763276523475234", Money = 250 };

            TransferHandler thd = new IngTransferHandler();

            thd.DoInTransfer(transfer);
          
        }
    }
}