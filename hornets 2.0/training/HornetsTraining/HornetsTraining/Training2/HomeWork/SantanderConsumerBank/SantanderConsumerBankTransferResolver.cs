using System;

namespace HornetsTraining.Training2.HomeWork.SantanderConsumerBank
{
    public class SantanderConsumerBankTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            var destinationBank = CheckBankNumber(transfer.DestinationBankAccount);
            var outgoingBank = CheckBankNumber(transfer.SourceBankAccount);

            if (destinationBank != null && outgoingBank != null)
            {
                destinationBank.DoInTransfer(transfer);
                outgoingBank.DoOutTransfer(transfer);
            }
            else
            {
                Console.WriteLine("Nie ma takiego banku");
            }
        }

        private static TransferHandler CheckBankNumber(string bankNum)
        {
            var bankList = BankList.GetBankList();
            try
            {
                return (bankNum.Length != 26) ? null : bankList[bankNum.Substring(2, 4)]();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}