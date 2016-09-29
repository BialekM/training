using System;
using System.Collections.Generic;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training2.HomeWork.BankMillenium;
using HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using HornetsTraining.Training2.HomeWork.MarcinJaniak;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training2.HomeWork.MichalMazur;
using HornetsTraining.Training2.HomeWork.NBP;
using HornetsTraining.Training2.HomeWork.PKOBP;
using HornetsTraining.Training2.HomeWork.SantanderConsumerBank;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTraining.Training2.HomeWork.Ing
{
    public class IngTransferHandlerFactory : DelegateFactoryBase<TransferHandler>
    {
        public IngTransferHandlerFactory()
        {
            ListOfInstances = new Dictionary<string, Func<TransferHandler>>()
            {
                     {"1010", () => new NBPTransferHandler()},
                     {"1440", () => new NordeaBankTransferHandler()},
                    {"1140", () => new MBankTransferHandler()},
            {"1680", () => new PlusBankTransferHandler()},
            {"2000", () => new RabobankPolskaTransferHandler()},
            {"2120", () => new SantanderConsumerBankTransferHandler()},
            {"1060", () => new BphTransferHandler()},
            {"2490", () => new AliorBankTransferHandler()},
            {"2160", () => new ToyotaBankTransferHandler()},
           {"1160", () => new BankMilleniumTransferHandler()} , 
          { "1050", () => new IngTransferHandler() },
                

            };
        }
    }
}