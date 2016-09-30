using System;
using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Homework.PawelKownacki
{
    public class TransferGenerator
    {
        private static readonly string[] ValidTransferIds =   { "1440", "1140", "1680", "2490",  "2160", "1160", "1050", "1010" };
        static readonly Random RandomNumber = new Random();

        public static Transfer GenerateTransfer()
        {
             Transfer transfer = new Transfer
             {
                 DestinationBankAccount = GenerateValidBankAccount(), SourceBankAccount = GenerateValidBankAccount(),
                 Money = RandomNumber.NextDouble()
             };
            return transfer;
        }

        private static string GenerateValidBankAccount()
        {
            string bankAccount = null;
            AddNumbers(ref bankAccount,2);
            bankAccount += ValidTransferIds[RandomNumber.Next(ValidTransferIds.Length)];
            AddNumbers(ref bankAccount,22);

            return bankAccount;


        }
        private static void AddNumbers(ref string temp, int numbersCount)
        {
            for (int i = 0; i < numbersCount; i++)
            {
                temp += RandomNumber.Next(10);
            }
        }
    }


}