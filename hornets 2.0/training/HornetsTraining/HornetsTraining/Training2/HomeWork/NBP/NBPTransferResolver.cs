using System;
using System.Linq;

namespace Toci.HornetsTraining.Training2.HomeWork.NBP
{
    public class NBPTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            var handler = GetBank(transfer);
            if (handler.DoInTransfer(transfer))
            {
                handler.DoOutTransfer(transfer);
            }
            else
            {
                // Tu powinien być fragment za przywrócenie danych do stanu poczatkowego,
                // w przypadku jakiegokolwiek problemu w DoInTransfer lub DoOutTransfer
            }
        }


        private TransferHandler GetBank(Transfer transfer)
        {
            var list = BankList.GetBankList();
            var key = getNumber(transfer.SourceBankAccount);
            return list[key]();
        }

        private string getNumber(string number)
        {
            return number.Replace(" ", string.Empty).Substring(2, 4);
        }

    }
}