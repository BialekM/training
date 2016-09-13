
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.Mbank;
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

            //TransferResolver transferResolver = new MBankTranferResolver();

            //transferResolver.DoTransfer(transfer);

            TransferHandler transferHandler = new MBankTansferHandler();

            //transferHandler.DoInTransfer(transfer);
        }

        [TestMethod]
        public void TransferTest2()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "1011404367632326523475234", SourceBankAccount = "1014405043732385943", Money = 250 };

            TransferHandler transferHandler = new MBankTansferHandler();

            transferHandler.DoInTransfer(transfer);
            transferHandler.DoInTransfer(transfer);
            transfer = new Transfer { DestinationBankAccount = "101140436763233456775234", SourceBankAccount = "101440504373245635943", Money = 250 };
            transferHandler.DoInTransfer(transfer);
            //transferHandler.DoOutTransfer(transfer);


        }
    }
}