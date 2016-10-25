using System;
using System.Collections.Generic; 
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;
using Toci.HornetsTraining.Training2.HomeWork.SantanderConsumerBank; 


namespace Toci.HornetsTraining.Training2.HomeWork.Ing
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