using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.HomeWork.LukaszSmierzchala;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.Factory;

namespace HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank
{
    public class ToyotaBankTransferResolver : TransferResolver
    {
        private readonly TransferHandlerFactory _banks;

        public ToyotaBankTransferResolver()
        {
            _banks = new TransferHandlerFactory();
        }

        public override void DoTransfer(Transfer transfer)
        {
            _banks.GetInstance(GetBankKey(transfer.SourceBankAccount)).DoOutTransfer(transfer);
            _banks.GetInstance(GetBankKey(transfer.DestinationBankAccount)).DoInTransfer(transfer);
        }

        private string GetBankKey(string accountNumber)
        {
            int keyNumberStart = 2;
            int keyNumberLength = 4;

            var operations = new LukaszSmierzchalaStringOperations();

            return operations.Substring(accountNumber, keyNumberStart, keyNumberLength);
        }
    }
}
