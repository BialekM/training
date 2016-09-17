using System.Diagnostics;
using HornetsTraining.Training2.ExtensionMethods;

namespace HornetsTraining.Training2.HomeWork
{
    class NordeaBankTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            TransferHandler SourceBank = BankFactory.CreateInstance(transfer.SourceBankAccount.GetBankId());
            TransferHandler DestinationBank = BankFactory.CreateInstance(transfer.DestinationBankAccount.GetBankId());
            if ((!SourceBank.Equals(null)) && !DestinationBank.Equals(null))
            {
                DestinationBank.DoInTransfer(transfer);
                SourceBank.DoOutTransfer(transfer);
            }
            else
            {
                Debug.WriteLine("Podano nieprawidłowy numer rachunku. Popraw wprowadzone dane.");
            }
            
        }
    }
}
