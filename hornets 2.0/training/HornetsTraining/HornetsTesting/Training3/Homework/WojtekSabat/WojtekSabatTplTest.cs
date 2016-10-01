using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training3.Homework.WojtekSabat;

namespace HornetsTesting.Training3.Homework.WojtekSabat
{
    [TestClass]
    public class WojtekSabatTplTest
    {
        [TestMethod]
        public void RandomizerTest()
        {
            for (int i = 0; i < 1000; i++)
            {
                var transfer = TransferRandomizer.GetRandomTransfer();
                Assert.AreEqual(transfer.DestinationBankAccount.Length,26);
                Assert.AreEqual(transfer.SourceBankAccount.Length,26);
                var destinationBankId = transfer.DestinationBankAccount.Substring(2, 4);
                var bankIds = BankList.GetBankList().Select(pair => pair.Key);
                Assert.IsTrue(bankIds.Contains(destinationBankId));
            }
        }

        [TestMethod]
        public void RunTplHomework()
        {
            var tplHomework = new WojtekSabatTplHomework();

            tplHomework.DoTransfers();
        }
    }
}