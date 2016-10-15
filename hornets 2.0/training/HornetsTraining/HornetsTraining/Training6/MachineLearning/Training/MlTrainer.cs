using System.IO;

namespace Toci.HornetsTraining.Training6.MachineLearning.Training
{
    public class MlTrainer
    {
        public const string FileName = "../../../HornetsTraining/Training6/MachineLearning/Populate/data/data.txt";
        public const char Delimiter = ' ';
        //int a = 15;
        //int b = 2; 

        protected double a = 3.8, b = 0.20;
        protected double momentum = 0.05; // czy na pewno taka nazwa ?

        public virtual void ReadFile()
        {
            StreamReader strRd = new StreamReader(FileName);
            string line;
            string[] values;
            double candidateX = 0, candidateY = 0;

            while (!strRd.EndOfStream)
            {
                line = strRd.ReadLine();
                values = line.Split(Delimiter);

                candidateX = double.Parse(values[0]);
                candidateY = double.Parse(values[1]);

                Train(candidateX, candidateY);
            }

            int i = 0;
        }

        protected virtual void Train(double candidateX, double candidateY)
        {
            // y = a + bx
            // x = (y - a) / b
            // a = y -bx
            // b = (y - a) / x
            //* / + -
            double y = a + b*candidateX;
            double x = (candidateY - a) / b;
            double candidateA = candidateY - b * candidateX;
            double candidateB = (candidateY - a)/candidateX;

            if (candidateA > a)
            {
                a = a + momentum;
                //b = b + momentum;
            }
            if (candidateB > b)
            {
                b = b + momentum;
            }
        }

        protected virtual void Train(double candidateX, double candidateY, double candidateX2, double candidateY2)
        {
            
        }
    }
}