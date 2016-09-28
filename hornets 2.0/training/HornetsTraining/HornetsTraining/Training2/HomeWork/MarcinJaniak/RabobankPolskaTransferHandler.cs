using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak
{
    public class RabobankPolskaTransferHandler:TransferHandler
    {
        public override bool DoInTransfer(Transfer transfer)
        {
            //Niepotrzebne sprawdzanie w tym miejscu
            if (transfer.DestinationBankAccount.Substring(2, 4) == "2000")
            {
                string fileName = "RabobankDoIn.txt";
                string fullPath = Path.GetFullPath(fileName);
                StreamWriter file = new StreamWriter(fullPath, true);
                file.WriteLine("Dest: " + transfer.DestinationBankAccount + " Source: " + transfer.SourceBankAccount + " Amount: " + transfer.Money.ToString());
                file.Close();
                return true;
            }
            return false;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            //Niepotrzebne sprawdzanie w tym miejscu
            if (transfer.SourceBankAccount.Substring(2, 4) == "2000")
            {
                string fileName = "RabobankDoOut.txt";
                string fullPath = Path.GetFullPath(fileName);
                StreamWriter file = new StreamWriter(fullPath, true);
                file.WriteLine("Dest: " + transfer.DestinationBankAccount + " Source: " + transfer.SourceBankAccount + " Amount: " + transfer.Money.ToString());
                file.Close();
                return true;
            }
            return false;
        }
    }
}
