using System;
using System.Collections.Generic;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training2.HomeWork.NBP;
using HornetsTraining.Training2.HomeWork.MarcinJaniak;
using HornetsTraining.Training2.HomeWork.SantanderConsumerBank;

namespace HornetsTraining.Training2.HomeWork
{
    public static class BankList
    {
        /// <summary>
        /// Wspólna lista banków, dopisywać swój śmiało :)
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Func<TransferHandler>> GetBankList()
        {
            var result = new Dictionary<string, Func<TransferHandler>>();
            result.Add("1010", () => new NBPTransferHandler()); 
            result.Add("1440", () => new NordeaBankTransferHandler());
            result.Add("1140", () => new MBankTransferHandler());
            result.Add("1680", () => new PlusBankTransferHandler());
            result.Add("2000", () => new RabobankPolskaTransferHandler());
            result.Add("2120", () => new SantanderConsumerBankTransferHandler());
            return result;
        }
    }
}