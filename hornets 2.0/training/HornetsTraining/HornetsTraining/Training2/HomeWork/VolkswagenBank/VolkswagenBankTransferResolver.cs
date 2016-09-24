using System;
using System.Diagnostics;

namespace HornetsTraining.Training2.HomeWork.VolkswagenBank
{
    public class VolkswagenBankTransferResolver: TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            var bankSource = SlawekKBankFactory.CreateInstance(transfer.SourceBankAccount.Substring(2, 4));
            var bankDestination = SlawekKBankFactory.CreateInstance(transfer.DestinationBankAccount.Substring(2, 4));
            try
            {
                bankDestination.DoInTransfer(transfer);
                bankSource.DoOutTransfer(transfer);
            }
            catch (Exception)
            {
                Debug.WriteLine("Błąd");
            }
        }
    }
}