using System.IO;

//namespace HornetsTraining.Training2.HomeWork.PKOBP
﻿namespace Toci.HornetsTraining.Training2.HomeWork.PKOBP
{
    public class PkobpTransferHandler : TransferHandler
    {
        public override bool DoInTransfer(Transfer transfer)
        {
            StreamWriter sw = new StreamWriter(@"..\Training2\Homework\PKOBP\ListOfOperaions.txt", true);

            sw.WriteLine("");
            sw.WriteLine("Przelew wewnętrzny:");
            sw.WriteLine("Numer konta źródłowego: {0}", transfer.DestinationBankAccount);
            sw.WriteLine("Numer konta docelowego: {0}", transfer.SourceBankAccount);
            sw.WriteLine("------------------------------------------------------------");

            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            StreamWriter sw = new StreamWriter(@"..\Training2\Homework\PKOBP\ListOfOperaions.txt", true);

            sw.WriteLine("");
            sw.WriteLine("Przelew zewnętrzny:");
            sw.WriteLine("Numer konta źródłowego: {0}", transfer.DestinationBankAccount);
            sw.WriteLine("Numer konta docelowego: {0}", transfer.SourceBankAccount);
            sw.WriteLine("------------------------------------------------------------");

            return true;
        }
    }
}