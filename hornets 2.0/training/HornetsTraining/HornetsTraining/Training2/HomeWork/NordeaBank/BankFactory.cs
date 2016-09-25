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

namespace HornetsTraining.Training2.HomeWork
{
    public static class BankFactory
    {
        private static Dictionary<string, Func<TransferHandler>> _bankList = new Dictionary
            <string, Func<TransferHandler>>()
            {
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
                {"1010", () => new NBPTransferHandler()},
                /*
                {"1750", () => new RaiffeisenBankTransferHandler()},
                {"1470", () => new EurobankTransferHandler()},
                {"1580", () => new Mercedes-BenzBankPolskaTransferHandler()},
                {"2030", () => new BGZTransferHandler()},
                {"2000", () => new RabobankPolskaTransferHandler()},
                {"1950", () => new IdeaBankTransferHandler()},
                {"1240", () => new PekaoTransferHandler()},
                {"1910", () => new DeutscheBankPolskaTransferHandler()},
                {"2480", () => new GetinNobleBankTransferHandler()},
                */
            };

        public static TransferHandler CreateInstance(string text)
        {
            return _bankList.ContainsKey(text) ? _bankList[text]() : null;
        }
    }
}