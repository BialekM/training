using System;
using System.IO;

namespace HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank
{
    public class AliorBankTransferHandler : TransferHandler
    {
        public override bool DoInTransfer(Transfer transfer)
        {
            StreamWriter sw = new StreamWriter(@"..\..\Training2\HomeWork\LukaszCichon\HistoriaOperacji.txt", true);

            sw.WriteLine("-----------------------------------------------------------------");
            sw.WriteLine("Transakcja wewnetrzna");
            sw.WriteLine("Data: {0}", DateTime.Now);
            sw.WriteLine("Numer konta docelowego: {0}", transfer.DestinationBankAccount);
            sw.WriteLine("Numer konta zrodlowego: {0}", transfer.SourceBankAccount);
            sw.WriteLine("Pieniadze: {0}", transfer.Money);
            sw.WriteLine();
            sw.Close();
            
            return (true);
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            StreamWriter sw = new StreamWriter(@"..\..\Training2\HomeWork\LukaszCichon\HistoriaOperacji.txt", true);

            sw.WriteLine("-----------------------------------------------------------------");
            sw.WriteLine("Transakcja zewnetrzna");
            sw.WriteLine("Data: {0}", DateTime.Now);
            sw.WriteLine("Numer konta docelowego: {0}", transfer.DestinationBankAccount);
            sw.WriteLine("Numer konta zrodlowego: {0}", transfer.SourceBankAccount);
            sw.WriteLine("Pieniadze: {0}", transfer.Money);
            sw.WriteLine();
            sw.Close();

            return (true);
        }
    } 
}