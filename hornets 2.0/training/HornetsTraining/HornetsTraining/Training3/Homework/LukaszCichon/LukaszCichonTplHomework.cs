using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.LukaszCichon
{
    public class LukaszCichonTplHomework : TplHomework
    {
        static Random numberRandom = new Random();

        public override void DoTransfers()
        {
            TransferResolver tr = new AliorBankTransferResolver();
            TaskFactory taskFactory = new TaskFactory();

            Stopwatch st = new Stopwatch();
            st.Start();

            for (int i = 0; i < 1000; i++)
            {
                Transfer transfers = new Transfer()
                {
                    DestinationBankAccount = GetNumber(2) + GetKey() + GetNumber(20),
                    SourceBankAccount = GetNumber(2) + GetKey() + GetNumber(20),
                    Money = numberRandom.Next()
                };
                taskFactory.StartNew(() => tr.DoTransfer(transfers));
                //tr.DoTransfer(transfers);
            }

            st.Stop();
            var result = st.Elapsed;
        }

        
        public string GetNumber(int x)
        {
            string result = string.Empty;

            for (int i = 0; i < x; i++)
            {
               result += numberRandom.Next(10).ToString();
            }
            return result;
        }


        public string GetKey()
        {
            List<string> idBankList = new List<string>()
            {
                "2490","1440","1140","1050","1010","1160"
            };

            return idBankList[numberRandom.Next(idBankList.Count)];
        }

    }
}