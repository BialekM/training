using System;
using System.IO;

namespace Toci.HornetsTraining.Training6.MachineLearning.Populate
{
    public class MlDataGenerator
    {
        public const string FileName = "../../../HornetsTraining/Training6/MachineLearning/Populate/data/data.txt";
        public const string Pattern = "{0} {1}";

        double x = 0;
        double y = 0;
        int a = 15;
        int b = 2;

        public void CreateFile()
        {
            StreamWriter strWr = new StreamWriter(FileName);

            for (int i = 0; i < 10000; i++)
            {
                Calculate();
                //save to file
                strWr.WriteLine(Pattern, x, y);
            }

            strWr.Close();
        }

        protected void Calculate()
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            System.Threading.Thread.Sleep(1);
            // generate x
            x = r.NextDouble() * 100000;
            // add noise

            double noiseX = r.NextDouble() / 5;
            double noiseY = r.NextDouble() / 4;

            x = x*noiseX;

            y = a + b*x;
            y = y*noiseY;
        }
    }
}