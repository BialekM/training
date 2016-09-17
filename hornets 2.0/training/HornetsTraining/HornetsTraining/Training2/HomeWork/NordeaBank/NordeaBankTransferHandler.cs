using System;

namespace HornetsTraining.Training2.HomeWork
{
    public class NordeaBankTransferHandler : TransferHandler
    {
        string operationType;

        public override bool DoInTransfer(Transfer transfer)
        {
            operationType = string.Format("Wpłacono {0} środków na konto {1} z konta {2}", transfer.Money, transfer.DestinationBankAccount, transfer.SourceBankAccount) + Environment.NewLine;
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            operationType = string.Format("Przelano {0} środki z konta {1} na konto {2}",transfer.Money,transfer.SourceBankAccount,transfer.DestinationBankAccount) + Environment.NewLine;
            return true;
        }
    }
}