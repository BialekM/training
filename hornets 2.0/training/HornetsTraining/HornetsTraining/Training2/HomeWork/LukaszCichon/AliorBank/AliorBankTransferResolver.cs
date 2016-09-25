using System.Collections.Specialized;
using System.Diagnostics;

namespace HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank
{
    public class AliorBankTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            string numberOfDestinationBank = transfer.DestinationBankAccount.Substring(2,4);
            string numberOfSourceBank = transfer.SourceBankAccount.Substring(2,4);

            var factory = new AliorBankTransferHandlerFactory();
            TransferHandler instance = factory.GetInstance(numberOfDestinationBank);

            if (instance != null)
            {
                checkAndDo(numberOfDestinationBank, numberOfSourceBank, instance, transfer);
            }
            else
            {
                Debug.WriteLine("Nie ma takiego banku");
            }
        }

        private void checkAndDo(string numberOfDestinationBank, string numberOfSourceBank, TransferHandler instance,Transfer transfer)
        {
            if (numberOfDestinationBank == numberOfSourceBank)
            {
                instance.DoInTransfer(transfer);
            }
            else
            {
                instance.DoOutTransfer(transfer);
            }
        }
    }
}
