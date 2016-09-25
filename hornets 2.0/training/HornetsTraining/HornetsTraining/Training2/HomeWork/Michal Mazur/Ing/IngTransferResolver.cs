using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using HornetsTraining.Training2.HomeWork.Ing;

namespace HornetsTraining.Training2.HomeWork.MichalMazur
{
    public class IngTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            string DestinationBankID = transfer.DestinationBankAccount.Substring(2, 4);
            string SourceBankID = transfer.SourceBankAccount.Substring(2, 4);
            bool StatusTransfer = false;
            
            var factory = new IngTransferHandlerFactory();
            TransferHandler handler = factory.GetInstance(DestinationBankID);

           if((StatusTransfer = ChechValidBankID(handler, transfer, DestinationBankID, SourceBankID))==true)
           {
                Debug.WriteLine("sent money" );
           }
           else
           {
                 Debug.WriteLine("error");
           }
      
        }

        private bool ChechValidBankID(TransferHandler handler, Transfer transfer, string Destination, string Source)
        {
            if (handler != null)
            {
                ChooseTransferType(handler, transfer, Destination, Source);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChooseTransferType(TransferHandler handler, Transfer t, string Destination, string Source)
        {

            if (Destination==Source)
            {
   
                handler.DoInTransfer(t);
      
                
            }
            else
            {
               // handler.DoOutTransfer(t);
            }
        }
    }
}

