using System;
using System.IO;

namespace Toci.HornetsTraining.Training2.HomeWork.VolkswagenBank
{
    public class VolkswagenBankTransferHandler: TransferHandler
    {
        public override bool DoInTransfer(Transfer transfer)
        {
            StreamWriter transferFile = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "//Volkswagen-history.txt", true);
            transferFile.WriteLine("************************************************************************");
            transferFile.WriteLine("Przelew przychodzący (Volkswagen Bank)");
            transferFile.Write("Nadawca: {0} - ", GetBankName(transfer.SourceBankAccount.Substring(2, 4)));
            transferFile.WriteLine("numer konta: {0}.", transfer.SourceBankAccount);
            transferFile.Write("Odbiorca: {0} - ", GetBankName(transfer.DestinationBankAccount.Substring(2, 4)));
            transferFile.WriteLine("numer konta: {0}.", transfer.DestinationBankAccount);
            transferFile.WriteLine("Kwota: {0}", transfer.Money);
            transferFile.WriteLine("************************************************************************");
            transferFile.Close();

            return true;

        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            StreamWriter transferFile = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "//Volkswagen-history.txt", true);
            transferFile.WriteLine("************************************************************************");
            transferFile.WriteLine("Przelew wychodzący (Volkswagen Bank)");
            transferFile.Write("Nadawca: {0} - ", GetBankName(transfer.SourceBankAccount.Substring(2, 4)));
            transferFile.WriteLine("numer konta: {0}.", transfer.SourceBankAccount);
            transferFile.Write("Odbiorca: {0} - ", GetBankName(transfer.DestinationBankAccount.Substring(2, 4)));
            transferFile.WriteLine("numer konta: {0}.", transfer.DestinationBankAccount);
            transferFile.WriteLine("Kwota: {0}", transfer.Money);
            transferFile.WriteLine("************************************************************************");
            transferFile.Close();

            return true;
        }

        public static string GetBankName(string account)
        {

            var x = SlawekKBankFactory.CreateInstance(account).ToString();
            int g = 0;
            string xx = "";
            for (int i = x.Length - 1; i > -1; i--)
            {
                if (x[i] == '.')
                {
                    x = x.Substring(i + 1, x.Length - 1 - i);
                    break;
                }
            }
            x = x.Replace("TransferHandler", "");
            return x;
        }
    }
}