using System;
using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Homework.AdrianPankiewicz
{
    public static class RandomTransferGenerator
    {
        private static readonly string[] validTransferIds = { "1440", "1140", "1680", "2490", "1060", "1090", "2160", "1160", "1050", "1010", "1020" };
        static readonly Random randomNumber = new Random();

        public static Transfer GenerateRandomTransfer()
        {
            Transfer transfer = new Transfer {DestinationBankAccount = GenerateRandomValidBankAccountNumber(),
                Money = randomNumber.NextDouble(), SourceBankAccount = GenerateRandomValidBankAccountNumber()};

            return transfer;
        }

        private static string GenerateRandomValidBankAccountNumber()
        {
            string randomBankAccount = "";

            AddRandomNumbers(ref randomBankAccount, 2);
            randomBankAccount += validTransferIds[randomNumber.Next(validTransferIds.Length)];
            AddRandomNumbers(ref randomBankAccount, 22);

            return randomBankAccount;
        }

        private static void AddRandomNumbers(ref string toModify, int numbersCount)
        {
            for (int i = 0; i < numbersCount; i++)
            {
                toModify += randomNumber.Next(10);
            }
        }
    }
}