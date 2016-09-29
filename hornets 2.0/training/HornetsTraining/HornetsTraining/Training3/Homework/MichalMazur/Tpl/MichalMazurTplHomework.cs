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
        private List<Task> tasks;
         public MichalMazurTplHomework()
        {
            tasks = new List<Task>();
            resolver = new IngTransferResolver();
            tf = new TaskFactory();
            bankIds = CreateListOfBankId().ToArray();
            transfers = GenerateListOfTransfers().ToArray();

        }
        public override void DoTransfers()
        {
            var WithTaskTime = WayOfPerformTransfer(resolver, tf,
                (tr, res, fac) => fac.StartNew(() =>
                {
                    try
                    {
                        resolver.DoTransfer(tr);
                    }
                    catch
                    {
                    }
                }));

            var WithoutTaskTime = WayOfPerformTransfer(resolver, tf,
               (tr, res, fac) => 
               {
                   try
                   {
                       resolver.DoTransfer(tr);
                   }
                   catch
                   {
                   }
               });


        }


        private TimeSpan WayOfPerformTransfer(IngTransferResolver resolver, TaskFactory tf, Action<Transfer, IngTransferResolver, TaskFactory> delAction)
        {
            Stopwatch s = Stopwatch.StartNew();
            foreach (var transfer in transfers)
            {
 
                delAction(transfer, resolver, tf);
            }


            s.Stop();
            return s.Elapsed;
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

            Stopwatch s = Stopwatch.StartNew();

            Parallel.For(0, 100, i => list.Add(GenerateRandomTransfer()));

            //for (int i = 0; i < 100; i++)
            //{
            //    list.Add(GenerateRandomTransfer());
            //}
            s.Stop();
            var ss = s.Elapsed;

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