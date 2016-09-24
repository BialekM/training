using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training2.HomeWork.Mbank;

namespace HornetsTraining.Training2.HomeWork
{
    public class PlusBankTransferResolver : TransferResolver // Remek
    {
        Dictionary<string, Func<TransferHandler>> bankIds = new Dictionary<string, Func<TransferHandler>>();

        public PlusBankTransferResolver()
        {
            bankIds.Add("1140", () => new MBankTransferHandler());
            bankIds.Add("1680", () => new PlusBankTransferHandler());
            bankIds.Add("1010", () => new NBP.NBPTransferHandler());
          
        }
       
        public override void DoTransfer(Transfer transfer)
        {
            // Do transfer
            string destinationBankNumber = GetBankNumber(transfer.DestinationBankAccount);
            string sourceBankNumber = GetBankNumber(transfer.SourceBankAccount);

            if(!bankIds.ContainsKey(destinationBankNumber) || !bankIds.ContainsKey(sourceBankNumber))
            {
                throw new Exception("Source or destination bank doesn't exists!");
            }

            bankIds[destinationBankNumber]().DoInTransfer(transfer);
            bankIds[sourceBankNumber]().DoOutTransfer(transfer);
        }

        private string GetBankNumber(string bankAccount)
        {
            return bankAccount.Substring(2, 4);
        }
    }
}
