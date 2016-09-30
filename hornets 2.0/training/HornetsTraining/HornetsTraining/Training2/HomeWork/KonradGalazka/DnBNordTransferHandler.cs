using System.IO;
using System;

namespace Toci.HornetsTraining.Training2.HomeWork.KonradGalazka
{
    public class DnBNordTransferHandler  : TransferHandler
    {
        StreamWriter sw = new StreamWriter(@"..\..\Training2\HomeWork\KonradGalazka\Historia.txt", true);
        public override bool DoInTransfer(Transfer transfer)
        {
            sw.WriteLine("Numer konta docelowego: "+ transfer.DestinationBankAccount);
            sw.WriteLine("Numer konta zrodlowego: "+ transfer.SourceBankAccount);
            sw.WriteLine("Pieniadze: "+ transfer.Money);
            sw.WriteLine();
            sw.Close();

            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            return true;
        }
    }
}