using System;
using System.IO;

namespace HornetsTraining.Training2.HomeWork.Mbank
{
    public class MBankTransferHandler : TransferHandler
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
            using (StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
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
            using (StreamWriter file = new StreamWriter(AccountCollectionInfoFilePath, true))
            {
                file.Write(bankAccountNumber + '\n');
                file.Write(Convert.ToString(money) + '\n');
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
            using (StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
            {
                lines = file.ReadToEnd().Split('\n');

                file.Close();
            }
            return lines;
        }

        private void ModifySpecifiedLine(int lineNumber, string newValue)
        {
            string[] lines = GetFileLines();
            lines[lineNumber] = newValue;

            using (StreamWriter file = new StreamWriter(AccountCollectionInfoFilePath))
            {
                for(int i=0; i < lines.Length -1; i++)
                { 
                    file.Write(lines[i] + '\n');
                }
                file.Close();
            }
        }


    }
}