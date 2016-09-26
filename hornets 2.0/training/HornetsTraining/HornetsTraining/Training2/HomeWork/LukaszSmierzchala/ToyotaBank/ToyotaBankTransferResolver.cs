using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training1.HomeWork.LukaszSmierzchala;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.Factory;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank
{
    public class ToyotaBankTransferResolver : TransferResolver
    {
        private readonly DelegateFactoryBase<TransferHandler> _banks;

        public ToyotaBankTransferResolver(DelegateFactoryBase<TransferHandler> factory)
        {
            _banks = factory;
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
