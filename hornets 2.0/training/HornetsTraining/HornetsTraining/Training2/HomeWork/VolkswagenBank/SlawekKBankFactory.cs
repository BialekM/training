using System;
using System.Collections.Generic;
using HornetsTraining.Training2.HomeWork.BankMillenium;
using HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using HornetsTraining.Training2.HomeWork.BZWBK;
using HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using HornetsTraining.Training2.HomeWork.Mbank;
using HornetsTraining.Training2.HomeWork.MichalMazur;
using HornetsTraining.Training2.HomeWork.NBP;
using HornetsTraining.Training2.HomeWork.PKOBP;
using HornetsTraining.Training2.HomeWork.SantanderConsumerBank;

namespace HornetsTraining.Training2.HomeWork.VolkswagenBank
{
    public class SlawekKBankFactory
    {
        private static Dictionary<string, Func<TransferHandler>> bankList = new Dictionary
            <string, Func<TransferHandler>>()
            {
                {"2130", () => new VolkswagenBankTransferHandler() },
                {"2120", () => new SantanderConsumerBankTransferHandler() },
                {"1440", () => new NordeaBankTransferHandler()},
                {"1020", () => new PkobpTransferHandler()},
                {"1050", () => new IngTransferHandler()},
                {"1140", () => new MBankTransferHandler()},
                {"2490", () => new AliorBankTransferHandler()},
                {"1060", () => new BphTransferHandler()},
                {"1160", () => new BankMilleniumTransferHandler()},
                {"1680", () => new PlusBankTransferHandler()},
                {"1090", () => new BZWBKTransferHandler()},
                {"2160", () => new ToyotaBankTransferHandler()},
                {"1010", () => new NBPTransferHandler()}
       };

        public static TransferHandler CreateInstance(string text)
        {
            return bankList.ContainsKey(text) ? bankList[text]() : null;
        }
    }
}