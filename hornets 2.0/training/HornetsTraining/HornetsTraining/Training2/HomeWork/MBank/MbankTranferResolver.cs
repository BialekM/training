using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using HornetsTraining.Training2.HomeWork.BZWBK;
using HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;

namespace HornetsTraining.Training2.HomeWork.Mbank
{
    public class MBankTranferResolver : TransferResolver
    {
        private readonly TransferHandlerFactory _factory = new TransferHandlerFactory();

        public override void DoTransfer(Transfer transfer)
        {
            getTransferHandler(transfer.SourceBankAccount).DoOutTransfer(transfer);
            getTransferHandler(transfer.DestinationBankAccount).DoInTransfer(transfer);
        }

        private TransferHandler getTransferHandler(string bankAccountNumber)
        {
            string bankId = bankAccountNumber.Substring(2, 4);
            return getTransferHandlerById(bankId);
        }

        private TransferHandler getTransferHandlerById(string bankId)
        {
            return _factory.GetInstance(bankId);
        }
    }
}