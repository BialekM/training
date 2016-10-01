using System;
using System.IO;

namespace Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz
{
    class BphTransferHandler : TransferHandler
    {
        
        private string path = @"C:\Users\Astaroth\Documents\Repo\Toci\hornets 2.0\training\HornetsTraining\HornetsTraining\Training2\HomeWork\BartoszMackiewicz\Transfers.txt";
        public override bool DoInTransfer(Transfer transfer)
        {
            string InTransfer = "IN Tranfer";

            using (StreamWriter transferWriter = new StreamWriter(path,true))
            { 
            transferWriter.WriteLine("{0}  {1}  SourceAccout:{2}  DestinationAccount:{3}  Amount:{4}",DateTime.Now,InTransfer,transfer.SourceBankAccount,transfer.DestinationBankAccount,transfer.Money);
             }
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            string OutTransfer = "Out Transfer";

            using (StreamWriter transferWriter = new StreamWriter(path,true))
            {
                transferWriter.WriteLine("{0}  {1}  SourceAccout:{2}  DestinationAccount:{3}  Amount:{4}", DateTime.Now,
                    OutTransfer, transfer.SourceBankAccount, transfer.DestinationBankAccount, transfer.Money);
            }
            return true;
        }
    }
}
