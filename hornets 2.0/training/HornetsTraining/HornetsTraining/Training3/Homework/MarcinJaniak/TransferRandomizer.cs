using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Homework.MarcinJaniak
{
    public class TransferRandomizer
    {
        private static Random rand = new Random(DateTime.Now.Millisecond);
        private List<string> list = BankList.GetBankList().Keys.ToList();

        public static Transfer GenerateTransfer()
        {

            return new Transfer
            {
                DestinationBankAccount = GenerateAccountNumber(),
                Money = rand.Next(1000,9999),
                SourceBankAccount = GenerateAccountNumber()
            };
        }

        public static string GenerateAccountNumber()
        {
            string temp = "";

            //TODO: mozna wyrzucic do funkcji
            for (int i = 0; i < 2; i++)
            {
                temp += rand.Next(0, 9);
            }

            temp += "2000";//list[rand.Next(0, list.Count()-1)];

            //TODO: mozna wyrzucic do funkcji
            for (int i = 0; i < 22; i++)
            {
                temp += rand.Next(0, 9);
            }

            return temp;
        }


    }
}