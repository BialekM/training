using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using HornetsTraining.Training2.HomeWork.PKOBP;

namespace Toci.HornetsTraining.Training2.HomeWork.PKOBP
{
    public class PkobpTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            string destinationBank = transfer.DestinationBankAccount.Substring(2, 4);
            string sourceBank = transfer.SourceBankAccount.Substring(2, 4);

            var factory = new PkobpBankFactory();
            TransferHandler inHandler = factory.GetInstance(destinationBank);

            if (inHandler != null)
            {
                Check(destinationBank, sourceBank, inHandler, transfer);
            }
            else
            {
                Debug.WriteLine("Podaj właściwy numer banku!");
            }
        }

        private void Check(string destinationBank, string sourceBank, TransferHandler inHandler, Transfer transfer)
        {
            if (destinationBank == sourceBank)
            {
                inHandler.DoInTransfer(transfer);
            }
            else
            {
                inHandler.DoOutTransfer(transfer);
            }
        }
    }
    
}