﻿using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Toci.HornetsTraining.Training2.HomeWork.BZWBK;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;

namespace Toci.HornetsTraining.Training2.HomeWork.Mbank
{
    internal class TransferHandlerFactory : DelegateFactoryBase<TransferHandler>
    {
        internal TransferHandlerFactory()
        {
            AddAllInstances();
        }

        private void AddAllInstances()
        {
            ListOfInstances.Add("1440", () => new NordeaBankTransferHandler());
            ListOfInstances.Add("1140", () => new MBankTransferHandler());
            ListOfInstances.Add("1680", () => new PlusBankTransferHandler());
            ListOfInstances.Add("2490", () => new AliorBankTransferHandler());
            ListOfInstances.Add("1060", () => new BphTransferHandler());
            ListOfInstances.Add("1090", () => new BZWBKTransferHandler());
            ListOfInstances.Add("2160", () => new ToyotaBankTransferHandler());
            ListOfInstances.Add("1160", () => new BankMilleniumTransferHandler());
            ListOfInstances.Add("1050", () => new IngTransferHandler());
            ListOfInstances.Add("1010", () => new NBPTransferHandler());
            ListOfInstances.Add("1020", () => new PkobpTransferHandler());
        }
    }
}