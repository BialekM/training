using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak
{
    public class RabobankPolskaTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {


            var inBankHandler = GetTransferHandler(transfer.SourceBankAccount);
            var outBankHandler = GetTransferHandler(transfer.DestinationBankAccount);

            inBankHandler.DoInTransfer(transfer);
            outBankHandler.DoOutTransfer(transfer);

        }

        public TransferHandler GetTransferHandler(string accountNumber)
        {
            var bankList = BankList.GetBankList();
            var bankCode = accountNumber.Substring(2, 4);

            return bankList[bankCode]();
        }

    }
}