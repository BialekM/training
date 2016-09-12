using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTraining.Training2.HomeWork
{
    class NordeaTransferResolver : TransferResolver
    {
        private Dictionary<string, TransferHandler> TransferRecognizer;
        public NordeaTransferResolver()
        {
            TransferRecognizer = new Dictionary<string, TransferHandler>
            {
                {"1440", new NordeaBankTransferHandler()},
                /*
                {"1020", new PKOBPTransferHandler()},
                {"1050", new INGTransferHandler()},
                {"1140", new MBankTransferHandler()},
                {"2490", new AliorBankTransferHandler()},
                {"1950", new IdeaBankTransferHandler()},
                {"1060", new BPHTransferHandler()},
                {"1160", new BankMillenniumTransferHandler()},
                {"1680", new PlusBankTransferHandler()},
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
            TransferRecognizer.Add("2333", new NordeaBankTransferHandler());
        }
        
        public override void DoTransfer(Transfer transfer)
        {
        }
    }
}
