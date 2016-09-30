using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.Ing;

namespace Toci.HornetsTraining.Training2.HomeWork.MichalMazur
{
    public class IngTransferResolver : TransferResolver
    {
        private DelegateFactoryBase<TransferHandler> factory; 
        public IngTransferResolver()
        {
            factory = new IngTransferHandlerFactory();

        }
        public override void DoTransfer(Transfer transfer)
        {
            string DestinationBankID = transfer.DestinationBankAccount.Substring(2, 4);
            string SourceBankID = transfer.SourceBankAccount.Substring(2, 4);

            var handlerIn = factory.GetInstance(SourceBankID);
            var handlerOut = factory.GetInstance(DestinationBankID);

            handlerIn.DoInTransfer(transfer);
            handlerOut.DoOutTransfer(transfer);
        }
        
    }
}

