using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.VolkswagenBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.SlawekKowal
{
    [TestClass]
    public class VolkswagenBankTest
    {
        [TestMethod]
        public void Test()
        {
            Transfer transfer = new Transfer { DestinationBankAccount = "102160436763276523475234", SourceBankAccount = "101140436763276523475234", Money = 250 };
            VolkswagenBankTransferResolver bank = new VolkswagenBankTransferResolver();
            bank.DoTransfer(transfer);
            
        }
    }
}