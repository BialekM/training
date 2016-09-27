using System;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.PawelMocarski.MercedesBenzBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.PawelMocarski
{
    [TestClass]
    public class MercedesBenzBankTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var transfer = new Transfer { DestinationBankAccount = "101580436763276523475234", SourceBankAccount = "10101050437285943", Money = 1800 };

            TransferResolver transferResolver = new MercedesBenzBankTransferResolver();

            transferResolver.DoTransfer(transfer);
        }
    }
}
