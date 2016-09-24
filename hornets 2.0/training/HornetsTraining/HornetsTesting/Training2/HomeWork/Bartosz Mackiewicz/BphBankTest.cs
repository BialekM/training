using System;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.Bartosz_Mackiewicz
{
    [TestClass]
    public class BphBankTest
    {
        [TestMethod]
        public void TestTransfer()
        {
            Transfer transfer = new Transfer {  SourceBankAccount = "86106024981111222233334444", DestinationBankAccount = "86106024981111222233334444", Money = 250 };

            TransferResolver transferResolver = new BphTransferResolver();

            transferResolver.DoTransfer(transfer);
        }
    }
}
