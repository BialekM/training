using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training2.HomeWork.PawelMocarski.MercedesBenzBank
{
    public class MercedesBenzBankTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            var sourceBankCode = transfer.SourceBankAccount.Substring(2, 4);
            var destinationBankCode = transfer.DestinationBankAccount.Substring(2, 4);

            var factory = new MercedesBenzBankFactory();
            var sourceHandler = factory.GetInstance(sourceBankCode);
            var destinationHandler = factory.GetInstance(destinationBankCode);

            if (sourceHandler == null || destinationHandler == null)
            {
                throw new Exception("Invalid account number");
            }

            var outTransferResult = sourceHandler.DoOutTransfer(transfer);

            if (outTransferResult)
            {
                destinationHandler.DoInTransfer(transfer);
            }
   
        }


    }
}
