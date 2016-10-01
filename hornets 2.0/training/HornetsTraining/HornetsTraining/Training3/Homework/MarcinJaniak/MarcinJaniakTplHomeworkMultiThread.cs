using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.MarcinJaniak
{
    public class MarcinJaniakTplHomeworkMultiThread : TplHomework
    {
        private readonly RabobankPolskaTransferResolver rpTR = new RabobankPolskaTransferResolver();

        public override void DoTransfers()
        {
            TaskFactory tf = new TaskFactory();

            Stopwatch st = new Stopwatch();

            //using(RabobankPolskaTransferResolver rpTR)


            //Pojawia się problem z multithreadem taki, że
            //Do obsługi transferów używamy transferResolvery, a do zapisu danych handlery
            //i wykonując w taki sposób transfery nie idzie w prosty (a przynajmniej znany mi) sposób zlockować i dispose'ować pierdółek
                for (int i = 0; i < 1000; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        tf.StartNew(DelMethod);
                    }
                }
            
            st.Stop();
            var result = st.Elapsed;
        }

        public void DelMethod()
        {
            rpTR.DoTransfer((TransferRandomizer.GenerateTransfer()));
        }
    }
}