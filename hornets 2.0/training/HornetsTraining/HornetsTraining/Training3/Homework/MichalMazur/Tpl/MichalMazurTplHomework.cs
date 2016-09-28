using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.MichalMazur.Tpl
{
    public class MichalMazurTplHomework : TplHomework
    {
        private readonly string[] bankIds;
        private readonly Transfer[] transfers;
        private Random rand = new Random(DateTime.Today.Millisecond);
        private IngTransferResolver resolver;
        private TaskFactory tf;
        public MichalMazurTplHomework()
        {
            tf = new TaskFactory();
            bankIds = CreateListOfBankId().ToArray();
            transfers = GenerateListOfTransfers().ToArray();

        }
        public override void DoTransfers()
        {
            resolver = new IngTransferResolver();

        
            foreach (var transfer in transfers)
            {
                Transfer transfer1 = transfer;
                tf.StartNew(() => resolver.DoTransfer(transfer1));

             }
        }


        private IEnumerable<string> CreateListOfBankId()
        {
            var dictWithBank = BankList.GetBankList();

            var listOfIds = dictWithBank.Select(k => k.Key);

            return listOfIds;
        }

        private List<Transfer> GenerateListOfTransfers()
        {
            List<Transfer> list = new List<Transfer>();

            for (int i = 0; i < 10000; i++)
            {
                list.Add(GenerateRandomTransfer());
            }


            return list;
        }

        private Transfer GenerateRandomTransfer()
        {
            Transfer t = new Transfer();
            t.Money = rand.Next(1, 9999);
            t.DestinationBankAccount = GenerateAccountNumber();
            t.SourceBankAccount = GenerateAccountNumber();

            return t;
        }

        private string GenerateAccountNumber()
        {
            string numberAccount = null;
            for (int i = 0; i < 23; i++)
            {
                if (i == 2)
                {
                    numberAccount += bankIds[rand.Next(0, bankIds.Length)];
                }
                else
                {
                    numberAccount += rand.Next(0, 9).ToString();

                }
            }

            return numberAccount;
        }
    }
}