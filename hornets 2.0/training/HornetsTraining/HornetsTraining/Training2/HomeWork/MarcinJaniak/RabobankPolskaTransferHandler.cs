using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak
{
    public class RabobankPolskaTransferHandler:TransferHandler, IDisposable
    {
        private StreamWriter file;


        private static object _lock = new object();


        public void Dispose()
        {
            file.Close();

        }



        public override bool DoInTransfer(Transfer transfer)
        {
            //Niepotrzebne sprawdzanie w tym miejscu
            if (transfer.DestinationBankAccount.Substring(2, 4) == "2000")
            {
                string fileName = "RabobankDoIn.txt";

                //TODO: relative path
                string fullPath =
                    @"C:\Users\Reav\Documents\training2\hornets 2.0\training\HornetsTraining\HornetsTraining\Training2\HomeWork\MarcinJaniak\" +
                    fileName;

                    //Path.GetFullPath(fileName);
                file = new StreamWriter(fullPath, true);

                lock (_lock)
                {
                    file.WriteLine("Dest: " + transfer.DestinationBankAccount + " Source: " + transfer.SourceBankAccount +
                                   " Amount: " + transfer.Money.ToString());
                }
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
                //string fullPath = Path.GetFullPath(fileName);
                //TODO: relative path
                string fullPath =
                   @"C:\Users\Reav\Documents\training2\hornets 2.0\training\HornetsTraining\HornetsTraining\Training2\HomeWork\MarcinJaniak\" +
                   fileName;
                file = new StreamWriter(fullPath, true);

                lock (_lock)
                {
                    file.WriteLine("Dest: " + transfer.DestinationBankAccount + " Source: " + transfer.SourceBankAccount + " Amount: " + transfer.Money.ToString());
                }
                     file.Close();
                return true;
            }
            return false;
        }
    }
}
