using System;
using System.Collections.Generic;
using HornetsTraining.Training2.HomeWork.BZWBK;
using HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;

namespace HornetsTraining.Training2.HomeWork
{
    public class DelegateBankList
    {
        public Dictionary<Func<string, bool>, Func<TransferHandler>> BankList = new Dictionary<Func<string, bool>, Func<TransferHandler>>
        {
            { (bankNumber) => bankNumber.Substring(2,4) == "1020", delegate { return new AliorBankTransferHandler();}},
            { (bankNumber) => bankNumber.Substring(2,4) == "1030", () => new BZWBKTransferHandler() },
        };


    }
}