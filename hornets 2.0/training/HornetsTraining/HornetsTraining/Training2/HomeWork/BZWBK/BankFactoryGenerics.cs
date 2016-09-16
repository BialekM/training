using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace HornetsTraining.Training2.HomeWork.BZWBK
{
    public static class BankFactoryGenerics
    {
        private static readonly Dictionary<string, Func<TransferHandler>> BankList = new Dictionary<string, Func<TransferHandler>>
        {
            {"1090", () => new BZWBKTransferHandler()},
            {"1140", () => new MbankTransferHandler()},
        };

        public static TransferHandler CreateTransferHandler(string nrb)
        {
            return BankList.ContainsKey(nrb) ? BankList[nrb]() : null;
        } 

    }
}
