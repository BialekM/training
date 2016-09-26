using System.Diagnostics;
using Ninject.Activation.Strategies;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;

namespace HornetsTraining.Training2.HomeWork.BankMillenium
{
    public class BankMilleniumTransferResolver : TransferResolver
    {

        private const int Start = 2;
        private const int Length = 4;

        public override void DoTransfer(Transfer transfer)
        {
            if (ValidateAccountNumber(transfer))
            {
                BankMilleniumFactory bankMilleniumFactory = new BankMilleniumFactory();

                bankMilleniumFactory.GetInstance(GetBankId(transfer.SourceBankAccount)).DoOutTransfer(transfer);
                bankMilleniumFactory.GetInstance(GetBankId(transfer.DestinationBankAccount)).DoInTransfer(transfer);
            }
            else
            {
                Debug.WriteLine("Nieprawidłowy numer konta");
            }

        }

        private string GetBankId(string accountNumber)
        {
            return accountNumber.Substring(Start, Length);
        }

        private bool ValidateAccountNumber(Transfer transfer)
        {
            return transfer.DestinationBankAccount.Length == 26 && transfer.SourceBankAccount.Length == 26;
        }
    }
}