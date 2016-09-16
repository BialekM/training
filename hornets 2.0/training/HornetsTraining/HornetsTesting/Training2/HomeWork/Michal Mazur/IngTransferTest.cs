using System.Collections.Generic;
using HornetsTesting.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.Ing;
using HornetsTraining.Training2.HomeWork.MichalMazur;
using HornetsTraining.Training2.HomeWork.MichalMazur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.MichalMazur
{
    [TestClass]
    public class TransfersTest
    {

        [TestMethod]
        public void TestTransfers()
        {
                  TransferResolver tr = new IngTransferResolver();
                  List<Transfer> transfers = CreateTransfers();
                  SendTranfers(transfers,tr);
            
        }

        private List<Transfer> CreateTransfers()
        {
            List<Transfer> transfers = new List<Transfer>()
            {
                   
                 new Transfer()
               {
                   DestinationBankAccount = "10105075647583950673647222", SourceBankAccount = "10114075647583959673647583", Money = 764
               },
                new Transfer()
               {
                   DestinationBankAccount = "10105075647583950673647222", SourceBankAccount = "10105075647583959673647583", Money = 764
               },
                new Transfer()
               {
                   DestinationBankAccount = "10168075647583950673647222", SourceBankAccount = "10216075647583959673647583", Money = 654 
               },
                 new Transfer()
               {
                   DestinationBankAccount = "10145075647583950673647583", SourceBankAccount = "10105075647583959673647583", Money = 250 
               },
           
            };

            return transfers;
        }

        private void SendTranfers(List<Transfer> transfers, TransferResolver tr)
        {
            foreach (var transfer in transfers)
            {
                tr.DoTransfer(transfer);
            }
        }
    }
}