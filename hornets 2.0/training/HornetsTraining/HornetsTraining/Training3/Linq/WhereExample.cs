using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Toci.HornetsTraining.Training2.HomeWork;

namespace Toci.HornetsTraining.Training3.Linq
{
    public class WhereExample
    {
        public TransferHandler GetTransferHandler()
        {
            Dictionary <string, Func<TransferHandler>> list = BankList.GetBankList();

            var result = list.Where<KeyValuePair<string, Func<TransferHandler>>>((keyValue) => keyValue.Key == "1010").ToList();

            return result[0].Value();
        }

        public void LinqSelectShowDown()
        {
            Dictionary<string, Func<TransferHandler>> list = BankList.GetBankList();

            //list.AsParallel().WithDegreeOfParallelism(4).ForAll(DoTransfer);

            //var result = list.Select((handler) => handler.Value().DoInTransfer(new Transfer()));

            List<string> bankAccounts = new List<string>
            {
                "432796523479564239536859734",
                "432796523479564239536859734",
                "432796523479564239536859734",
                "431010523479564239536859734",
                "432796523479564239536859734",
                "458634786735685764567586654",
            };

            var result = bankAccounts.Join(list, GetBanksId, kv => kv.Key, (s, pair) => pair.Value());

            bankAccounts.Add("121440645656456456745754");

            var test = result.ToList();


        }

        private string GetBanksId(string accountNumber)
        {
            return accountNumber.Substring(2, 4);
        }

        private void DoTransfer(KeyValuePair<string, Func<TransferHandler>> handler)
        {
            handler.Value().DoInTransfer(new Transfer());

            //return true;
        }
    }
}