using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTesting.Training2.HomeWork.LukaszSmierzchala.ForInitializing;
using HornetsTraining.Training2.HomeWork;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.DatabaseClass;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.HomeWork.LukaszSmierzchala
{
    [TestClass]
    public class ToyotaBankTest
    {
        [TestMethod]
        public void TestToyotaBankTransferHandler()
        {
            int keyStart = 2;
            int keyLength = 4;
            string toyotaKey = "2160";

            var test = new TransferTestValues();
            var toyotaBankTransferHandler = new ToyotaBankTransferHandler();

            IEnumerable<Transfer> toyotaSourceBankAcc = test.ValuesList.Where(transefer =>
                transefer.SourceBankAccount.Substring(keyStart, keyLength) == toyotaKey);

            IEnumerable<Transfer> toyotaDestinationBankAcc = test.ValuesList.Where(transefer =>
                transefer.DestinationBankAccount.Substring(keyStart, keyLength) == toyotaKey);


            foreach (var transfer in toyotaSourceBankAcc)
            {
                TestMoney(toyotaBankTransferHandler.DoOutTransfer,
                    transfer, transfer.SourceBankAccount, -transfer.Money);
            }

            foreach (var transfer in toyotaDestinationBankAcc)
            {
                TestMoney(toyotaBankTransferHandler.DoInTransfer,
                    transfer, transfer.DestinationBankAccount, transfer.Money);
            }

        }


        private void TestMoney(Func<Transfer, bool> operation,
                               Transfer transfer,
                               string accountNumber,
                               double money)
        {
            try
            {
                double preMoney;

                using (var database = new BankAccountsDataContext())
                {
                    preMoney = database.BankAccounts.Single(account =>
                        account.AccountNumber == accountNumber).Money.Value;
                }

                operation(transfer);

                using (var database = new BankAccountsDataContext())
                {
                    Assert.AreEqual(preMoney + money,
                        database.BankAccounts.Single(account =>
                            account.AccountNumber == accountNumber).Money.Value);
                }
            }
            catch (InvalidOperationException)
            {
                Assert.AreEqual(false, operation(transfer));
            }
        }
    }
}
