using System;
using System.Collections.Generic;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training2.HomeWork.BankMillenium;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training2.HomeWork.MichalMazur;
using HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank
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