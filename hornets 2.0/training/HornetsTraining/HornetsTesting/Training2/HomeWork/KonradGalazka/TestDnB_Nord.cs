using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.KonradGalazka;

namespace HornetsTesting.Training2.HomeWork.KonradGalazka
{
    [TestClass]
    public class TestDnB_Nord
    {
        [TestMethod]
        public void Test()
        {
            TransferResolver tr = new KonradGalazkaTransferResolver();
            List<Transfer> transfers = DoTransfers();
            Send(transfers,tr);
        }

        public List<Transfer> DoTransfers()
        {
            List<Transfer> transfers = new List<Transfer>()
            {
                new Transfer()
                {
                    DestinationBankAccount = "10219075647583950673647222", SourceBankAccount = "10105075647583950688888888", Money = 100
                },

                new Transfer()
                {
                    DestinationBankAccount = "10114075647583950673647222", SourceBankAccount = "10105075647583950688888888", Money = 150
                },
            };

            return transfers;
        }

        public void Send(List<Transfer> transfers, TransferResolver tr)
        {
            foreach (var transfer in transfers)
            {
                tr.DoTransfer(transfer);
            }
        }
    }
}