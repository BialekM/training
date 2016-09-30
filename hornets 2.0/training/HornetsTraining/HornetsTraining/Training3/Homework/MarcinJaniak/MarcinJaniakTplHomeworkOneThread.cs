using System.Diagnostics;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak;
using Toci.HornetsTraining.Training3.Homework.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.MarcinJaniak
{
    public class MarcinJaniakTplHomeworkOneThread : TplHomework
    {
        public override void DoTransfers()
        {
            TaskFactory tf = new TaskFactory();
            RabobankPolskaTransferResolver rpTR = new RabobankPolskaTransferResolver();

            Stopwatch st = new Stopwatch();
            for (int i = 0; i < 1000; i++)
            {
                rpTR.DoTransfer((TransferRandomizer.GenerateTransfer()));
            }

            st.Stop();
            var result = st.Elapsed;
        }
    }
}