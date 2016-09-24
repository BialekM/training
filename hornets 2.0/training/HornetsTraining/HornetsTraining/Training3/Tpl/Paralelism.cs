using System.Diagnostics;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training3.Tpl
{
    public class Paralelism
    {
        private Randomizer random; // = new Randomizer();

        public void CreateMultiTaskFileSave()
        {
            TaskFactory tf = new TaskFactory();

            using (random = new Randomizer())
            {

                //for (;;)
                Stopwatch st = new Stopwatch();

                st.Start();
                    for (int i = 0; i < 10000; i++)
                    {
                        //tf.StartNew(DelMethod);

                        DelMethod();
                    }

                st.Stop();

                var result = st.Elapsed;
            }

            //r.Save();
        }

        private void DelMethod()
        {
            random.Save();
        }
    }
}