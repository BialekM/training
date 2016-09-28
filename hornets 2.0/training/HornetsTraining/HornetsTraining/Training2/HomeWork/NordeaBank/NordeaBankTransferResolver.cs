using System;
using System.Diagnostics;
using Toci.HornetsTraining.Training2.ExtensionMethods;

namespace Toci.HornetsTraining.Training2.HomeWork
{
    public class NordeaBankTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            try
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
            catch(Exception)
            {
                Debug.WriteLine("Podano nieprawidłowy numer rachunku. Popraw wprowadzone dane.");
            }
            
        }
    }
}
