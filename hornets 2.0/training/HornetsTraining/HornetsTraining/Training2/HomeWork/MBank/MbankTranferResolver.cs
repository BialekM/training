using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HornetsTraining.Training2.HomeWork.Mbank
{
    public class MBankTranferResolver : TransferResolver
    {
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
            return getTransferHandlersCollection()[bankId];
        }

        private Dictionary<string, TransferHandler> getTransferHandlersCollection()
        {
            return new Dictionary<string, TransferHandler>
            {
                {"1440", new NordeaBankTransferHandler()},
                {"1140", new MbankTransferHandler()},
                //{"1680", new PlusBankTransferHandler()},
                /*
                {"1020", new PKOBPTransferHandler()},
                {"1050", new INGTransferHandler()},
                {"2490", new AliorBankTransferHandler()},
                {"1950", new IdeaBankTransferHandler()},
                {"1060", new BPHTransferHandler()},
                {"1160", new BankMillenniumTransferHandler()},
                {"1090", new BZWBKTransferHandler()},
                {"1240", new PekaoTransferHandler()},
                {"1910", new DeutscheBankPolskaTransferHandler()},
                {"2480", new GetinNobleBankTransferHandler()},
                {"2160", new ToyotaBankTransferHandler()},
                {"1750", new RaiffeisenBankTransferHandler()},
                {"1470", new EurobankTransferHandler()},
                {"1580", new Mercedes-BenzBankPolskaTransferHandler()},
                {"2030", new BGZTransferHandler()},
                {"1010", new NarodowyBankPolskiTransferHandler()},
                {"2000", new RabobankPolskaTransferHandler()},
                */

            };
        }

    }
}