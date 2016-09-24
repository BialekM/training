using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using HornetsTraining.Training2.HomeWork;

namespace HornetsTraining.Training2.HomeWork.MichalMazur
{
    public class IngTransferHandler : TransferHandler
    {
        private int AccountMoney;
        public override bool DoInTransfer(Transfer transfer)
        {

            StoreInfoInTxtFile("IN transaction", transfer);
            return (true);

        }

        public override bool DoOutTransfer(Transfer transfer)
        {

            StoreInfoInTxtFile("Out transaction", transfer);
            return true;
         }

        private void StoreInfoInTxtFile(string typeTransaction, Transfer transfer)
        {
            StreamWriter sw = new StreamWriter(@"HistoryOfTransfers.txt", true);

            sw.WriteLine(typeTransaction);
            sw.WriteLine("Date: {0}", DateTime.Now);
            sw.WriteLine("Source Account: {0}", transfer.SourceBankAccount);
            sw.WriteLine("Money: {0}", transfer.Money);
            sw.WriteLine();
            sw.Close();
        }
    }
}