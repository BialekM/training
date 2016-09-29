using Toci.HornetsTraining.Training2.ExtensionMethods;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork
{
    [TestClass]
    public class NordeaBankTests
    {
        [TestMethod]
        public void NordeaBankTest()
        {
            //NordeaBankTransferResolver nordea = new NordeaBankTransferResolver();
            Transfer transfer = new Transfer
            {
                DestinationBankAccount = "121440",
                SourceBankAccount = "121020",
                Money = 1250
            };
            Assert.IsInstanceOfType(BankFactory.CreateInstance(transfer.DestinationBankAccount.GetBankId()), typeof(NordeaBankTransferHandler));
            Assert.IsInstanceOfType(BankFactory.CreateInstance(transfer.SourceBankAccount.GetBankId()), typeof(PkobpTransferHandler));
            Assert.AreEqual(transfer.Money,1250);
        }
    }
}