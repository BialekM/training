﻿using System;
using System.Text;
using Ninject.Activation.Strategies;

namespace Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz
{
    public class BphTransferResolver : TransferResolver
    {
        private const int BankIdLength = 4;

        public override void DoTransfer(Transfer transfer)
        {
            if (CheckAccountNumber(transfer))
            {
                BphBankFactory bankFactory = new BphBankFactory();

                bankFactory.GetInstance(GetBankId(transfer.SourceBankAccount, 2, 4)).DoOutTransfer(transfer);
                bankFactory.GetInstance(GetBankId(transfer.DestinationBankAccount, 2, 4)).DoInTransfer(transfer);
            }
            else
            {
                Console.WriteLine("Nieprawidłowy numer konta!");
            }
        }

        public string GetBankId (string accountNumber,int start,int length)
        {
            return accountNumber.Substring(start, BankIdLength);
        }

        public bool CheckAccountNumber(Transfer transfer)
        {
            return transfer.DestinationBankAccount.Length == 26 && transfer.SourceBankAccount.Length == 26;
        }
    }
  }
   
