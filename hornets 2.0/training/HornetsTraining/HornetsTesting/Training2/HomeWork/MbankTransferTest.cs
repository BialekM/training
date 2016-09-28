
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class MBankTransferTest
    {
        [TestMethod]
        public void TransferTest()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "101140436763276523475234", SourceBankAccount = "10144050437285943", Money = 250 };

            TransferResolver transferResolver = new MBankTranferResolver();

            transferResolver.DoTransfer(transfer);
        }
    }
}