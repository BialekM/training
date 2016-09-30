using System;
using System.Collections.Generic;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Toci.HornetsTraining.Training2.HomeWork.BZWBK;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;
using Toci.HornetsTraining.Training2.HomeWork.SantanderConsumerBank;

namespace Toci.HornetsTraining.Training2.HomeWork.VolkswagenBank
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