using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace HornetsTraining.Training2.HomeWork.Mbank
{
    public class MBankTansferHandler : TransferHandler
    {
        public const string AccountCollectionInfoFilePath = "../../../HornetsTraining/Training2/HomeWork/MBank/MBankAccountInfo.txt";
        public override bool DoInTransfer(Transfer transfer)
        {
            int accoutMoneyLine = GetAccountMoneyLine(transfer.DestinationBankAccount);
            bool accountExists = accoutMoneyLine > 0;
            if (accountExists)
            {
                IncrementMoneyAmmount(accoutMoneyLine, transfer.Money);
            }
            else
            {
                AppendNewRecord(transfer.DestinationBankAccount, transfer.Money);
            }


            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            int accoutMoneyLine = GetAccountMoneyLine(transfer.SourceBankAccount);
            bool accountExists = accoutMoneyLine > 0;
            if (accountExists)
            {
                IncrementMoneyAmmount(accoutMoneyLine, -(transfer.Money));
            }
            else
            {
                return false;
            }

            return true;
        }

        private int GetAccountMoneyLine(string bankAccountNumber)
        {
            using (System.IO.StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
            {
                string line = file.ReadLine();
                int currentLineNumber = 1;

                while (line != null)
                {
                    if (line == bankAccountNumber)
                        return currentLineNumber;

                    line = file.ReadLine();
                    currentLineNumber++;
                }

                file.Close();
            }
            return -1;
        }

        private void AppendNewRecord(string bankAccountNumber, double money)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(AccountCollectionInfoFilePath, true))
            {
                file.WriteLine(bankAccountNumber);
                file.WriteLine(money);
                file.Close();
            }
        }

        private void IncrementMoneyAmmount(int lineNumber, double value)
        {
            string moneyLine = GetSpecifiedLine(lineNumber);
            double previousMoneyAmmount = Convert.ToDouble(moneyLine);
            ModifySpecifiedLine(lineNumber, Convert.ToString(previousMoneyAmmount + value));
        }

        private string GetSpecifiedLine(int lineNumber)
        {
            return GetFileLines()[lineNumber];
        }

        private string[] GetFileLines()
        {
            string[] lines;
            using (System.IO.StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
            {
                lines = file.ReadToEnd().Split('\n', '\r');

                file.Close();
            }
            return lines;
        }

        private void ModifySpecifiedLine(int lineNumber, string newValue)
        {
            string[] lines = GetFileLines();
            lines[lineNumber] = '\n' + newValue + '\n';

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(AccountCollectionInfoFilePath))
            {
                foreach (string line in lines)
                {
                    file.Write(line);
                }
                file.Close();
            }
        }


    }
}