using System.Diagnostics;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.BankMillenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.PawelKownacki
{
    [TestClass]
    public class BankMilleniumTest
    {
        [TestMethod]
        public void BankMilleniumTransferTest()
        {

            

            Transfer transfer = new Transfer { SourceBankAccount = "45101056457876543212345665", DestinationBankAccount = "34116078659874356786123765", Money = 10000 };

            //BankAccountLength(transfer.DestinationBankAccount);
            //BankAccountLength(transfer.SourceBankAccount);

            BankMilleniumTransferResolver bankMilleniumTransferResolver = new BankMilleniumTransferResolver();

            bankMilleniumTransferResolver.DoTransfer(transfer);
            
        }

        //public void BankAccountLength(string accountNumber)
        //{
        //    Debug.WriteLine(accountNumber.Length); 
        //}
    }
}