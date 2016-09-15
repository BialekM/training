using HornetsTraining.Training2.HomeWork;

namespace HornetsTraining.Training2.HomeWork.MichalMazur
{
    public class IngTransferHandler : TransferHandler
    {
        
        public override bool DoInTransfer(Transfer transfer)
        {
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            return true;
         }
    }
}