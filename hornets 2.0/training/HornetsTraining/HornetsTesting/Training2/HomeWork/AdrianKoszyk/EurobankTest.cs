using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.AdrianKoszyk.Eurobank;

namespace HornetsTesting.Training2.HomeWork.AdrianKoszyk
{

    [TestClass]
    public class EurobankTest
    {
        [TestMethod]
        public void EurobankTests()
        {
            TransferResolver transf = new EurobankTransfersResolver();
            List<Transfer> transfers = CreateTransfers();
            SendTranfers(transfers, transf);
        }

        private List<Transfer> CreateTransfers()
        {
            List<Transfer> transfers = new List<Transfer>()
            {

                new Transfer()
                {
                    DestinationBankAccount = "10249075647583950673647222",
                    SourceBankAccount = "10147075647583959673647583",
                    Money = 764
                },
                new Transfer()
                {
                    DestinationBankAccount = "10105075647583950673647222",
                    SourceBankAccount = "10147075647583959673647583",
                    Money = 224
                },
                new Transfer()
                {
                    DestinationBankAccount = "10249056475839506736472232",
                    SourceBankAccount = "10147075647583959673647583",
                    Money = 654
                },
                new Transfer()
                {
                    DestinationBankAccount = "10114075647583950673647583",
                    SourceBankAccount = "10147075647583959673647583",
                    Money = 250
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