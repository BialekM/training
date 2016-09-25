namespace HornetsTraining.Training2.HomeWork.BankMillenium
{
    public class BankMilleniumTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            string sourceBankAccoutNumber = transfer.SourceBankAccount.Substring(2,4) ;
            string destinationBankAccountNumber = transfer.DestinationBankAccount.Substring(2, 4);

        }
    }
}