using System;
using System.Collections.Generic;
//using HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
//using HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
//using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
//using HornetsTraining.Training2.HomeWork.Mbank;
//using HornetsTraining.Training2.HomeWork.NBP;
//using HornetsTraining.Training2.HomeWork.MarcinJaniak;
//using HornetsTraining.Training2.HomeWork.PKOBP;
//using HornetsTraining.Training2.HomeWork.SantanderConsumerBank;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Toci.HornetsTraining.Training2.HomeWork.KonradGalazka;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;
using Toci.HornetsTraining.Training2.HomeWork.SantanderConsumerBank;

namespace Toci.HornetsTraining.Training2.HomeWork
{
    public static class BankList
    {
        /// <summary>
        /// Wspólna lista banków, dopisywać swój śmiało :)
        /// </summary>
        /// <returns></returns>
        public static Dictionary <string, Func<TransferHandler>> GetBankList()
        {
            var result = new Dictionary<string, Func<TransferHandler>>();
            result.Add("1010", () => new NBPTransferHandler()); 
            result.Add("1440", () => new NordeaBankTransferHandler());
            result.Add("1140", () => new MBankTransferHandler());
            result.Add("1680", () => new PlusBankTransferHandler());
            result.Add("2000", () => new RabobankPolskaTransferHandler());
            result.Add("2120", () => new SantanderConsumerBankTransferHandler());
            result.Add("1060", () => new BphTransferHandler());
            result.Add("2490", () => new AliorBankTransferHandler());
            result.Add("2160", () => new ToyotaBankTransferHandler());
            result.Add("1020", () => new PkobpTransferHandler());
            result.Add("1160", () => new BankMilleniumTransferHandler() );
            result.Add("1050", () => new IngTransferHandler() );
            result.Add("2190", () => new DnBNordTransferHandler() );
            //result["1010"] += () => new BphTransferHandler();

            return result;
        }
    }
}