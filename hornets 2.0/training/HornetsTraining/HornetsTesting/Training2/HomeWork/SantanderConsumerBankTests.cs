using System.Collections.Generic;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.SantanderConsumerBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class SantanderConsumerBankTests
    {
        [TestMethod]
        public void TransferTest()
        {
            TransferResolver transfer = new SantanderConsumerBankTransferResolver();
            List<Transfer> transfers = PrepareTransfers();
            ExecuteTransfers(transfers, transfer);
        }

        private List<Transfer> PrepareTransfers()
        {
            List<Transfer> listOfTransfers = new List<Transfer>()
            {
                 new Transfer()
               {
                   DestinationBankAccount = "10212075647583950673647222", SourceBankAccount = "10101075647583959673647583", Money = 500
               }, 
               new Transfer()
               {
                   DestinationBankAccount = "10101075647583950673647333", SourceBankAccount = "10212075647583959673647583", Money = 800
               },
                new Transfer()
               {
                   DestinationBankAccount = "10212075647583950673789632", SourceBankAccount = "10102075647583959673123456", Money = 1000
               }
            };

            return listOfTransfers;
        }

        private void ExecuteTransfers(List<Transfer> transfers, TransferResolver transfer)
        {
            foreach (var tr in transfers)
            {
                transfer.DoTransfer(tr);
            }
        }

    }
}