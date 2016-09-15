using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.DatabaseClass;

namespace HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank
{
    public class ToyotaBankTransferHandler : TransferHandler
    {
        public override bool DoInTransfer(Transfer transfer)
        {
            using (var database = new BankAccountsDataContext())
            {
                try
                {
                    database.BankAccounts.Single(account => account.AccountNumber == transfer.DestinationBankAccount).
                        Money += transfer.Money;

                    database.SubmitChanges();

                    return true;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Destination bank account doesn't exist in database");
                    return false;
                }
            }
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            using (var database = new BankAccountsDataContext())
            {
                try
                {
                    database.BankAccounts.Single(account => account.AccountNumber == transfer.SourceBankAccount).
                        Money -= transfer.Money;

                    database.SubmitChanges();

                    return true;
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Source bank account doesn't exist in database");
                    return false;
                }
            }
        }

    }
}
