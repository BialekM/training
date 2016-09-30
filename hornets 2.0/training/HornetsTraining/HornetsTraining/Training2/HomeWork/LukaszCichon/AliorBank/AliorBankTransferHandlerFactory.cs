using System;
using System.Collections.Generic;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;

namespace Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank
{
    public class AliorBankTransferHandlerFactory  : DelegateFactoryBase<TransferHandler>
    {
        public AliorBankTransferHandlerFactory()
        {
            ListOfInstances = new Dictionary<string, Func<TransferHandler>>()
            {
                {"2490", () => new AliorBankTransferHandler()},
                {"2160", () => new ToyotaBankTransferHandler()},
                {"1440", () => new NordeaBankTransferHandler()},
                {"1140", () => new MBankTransferHandler()},
                {"1680", () => new PlusBankTransferHandler()},
                {"1050", () => new IngTransferHandler()},
                {"1010", () => new NBPTransferHandler()},
                {"1160", () => new BankMilleniumTransferHandler()}
            };
        }
    }
}