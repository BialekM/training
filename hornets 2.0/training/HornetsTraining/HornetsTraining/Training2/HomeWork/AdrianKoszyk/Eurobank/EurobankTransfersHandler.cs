using System.IO;

namespace Toci.HornetsTraining.Training2.HomeWork.AdrianKoszyk.Eurobank
{
    public class EurobankTransfersHandler : TransferHandler
    {
        private string path =
            @"D:\KursCsharp\hornets 2.0\training\HornetsTraining\HornetsTraining\Training2\HomeWork\AdrianKoszyk\Eurobank\Transfers.txt";

        public override bool DoInTransfer(Transfer transfer)
        {
            StreamWriter transfersWritter = new StreamWriter(path,true);
            transfersWritter.WriteLine("Nr konta zrodlowego : {0}  Nr konta docelowego : {1}  Przelano : {2}zl.",transfer.SourceBankAccount , transfer.DestinationBankAccount, transfer.Money);

            
            transfersWritter.Close();
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            StreamWriter transfersWritter = new StreamWriter(path,true);
            transfersWritter.WriteLine("Nr konta zrodlowego : {1}  Nr konta docelowego : {0}  Przelano : {2}zl.", transfer.SourceBankAccount, transfer.DestinationBankAccount, transfer.Money);

            transfersWritter.Close();
            return true;
        }
    }
}