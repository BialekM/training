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
                appendNewRecord(transfer.DestinationBankAccount, transfer.Money);
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
                        return currentLineNumber+1;

                    line = file.ReadLine();
                    currentLineNumber++;
                }

                file.Close();
            }
            return -1;
        }

        private void appendNewRecord(string bankAccountNumber, double money)
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
            double previousMoneyAmmount = Convert.ToDouble(getSpecifiedLine(lineNumber));
            modifySpecifiedLine(lineNumber, Convert.ToString(previousMoneyAmmount + value));
        }

        private string getSpecifiedLine(int lineNumber)
        {
            string ret;
            using (System.IO.StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
            {
                for (int i = 0; i < lineNumber; i++)
                    file.ReadLine();

                 ret = file.ReadLine();
                file.Close();
            }
            return ret;
        }

        private void modifySpecifiedLine(int lineNumber, string newValue)
        {
            using (System.IO.StreamReader file = new StreamReader(AccountCollectionInfoFilePath))
            {
                for (int i = 0; i < lineNumber; i++)
                    file.ReadLine();

                //delete line and add newValue
                file.Close();
            }
        }
    }
}