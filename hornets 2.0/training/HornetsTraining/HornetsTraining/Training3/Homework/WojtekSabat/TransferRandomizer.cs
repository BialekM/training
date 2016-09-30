using System;
using System.Linq;
using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Homework.WojtekSabat
{
    public static class TransferRandomizer
    {
        private static readonly Random Random = new Random();

        private static string GetRandomAccountNumber()
        {
            var bankIds = BankList.GetBankList().Select(pair => pair.Key).ToList();

            var randomBankId = bankIds[Random.Next(bankIds.Count)];
            return GetStringOfRandomDigits(2) + "1010"/*randomBankId*/ + GetStringOfRandomDigits(20);
        }

        private static string GetStringOfRandomDigits(int numberOfDigits)
        {
            string str = "";
            for (int i = 0; i < numberOfDigits; i++)
            {
                str += Random.Next(10).ToString();
            }
            return str;
        }

        public static Transfer GetRandomTransfer()
        {
            return new Transfer()
            {
                DestinationBankAccount = GetRandomAccountNumber(),
                SourceBankAccount = GetRandomAccountNumber(),
                Money = Random.Next(1, 10000000)
            };
        }
    }
}