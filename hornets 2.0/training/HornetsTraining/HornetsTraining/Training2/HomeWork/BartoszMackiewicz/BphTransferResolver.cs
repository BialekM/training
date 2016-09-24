using System;
using System.Text;
using Ninject.Activation.Strategies;

namespace HornetsTraining.Training2.HomeWork.BartoszMackiewicz
{
    public class BphTransferResolver : TransferResolver
    {
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
            return accountNumber.Substring(start, length);
        }

        public bool CheckAccountNumber(Transfer transfer)
        {
            return transfer.DestinationBankAccount.Length == 26 && transfer.SourceBankAccount.Length == 26;
        }
    }
  }
   
