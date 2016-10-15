using System.Collections.Generic;
using IronPython.Runtime;

namespace Toci.HornetsTraining.Training6.NeuralNetworks
{
    public class NeuralNetwork
    {
        public Dictionary<int, Perceptron> Inputs { get; set; }
        public Dictionary<int, Dictionary<int, Perceptron>> Hidden { get; set; }
        public Dictionary<int, Perceptron> Outputs { get; set; }

        public NeuralNetwork(int inputsCount, int hiddenNumber, int hiddenCount, int outputCount)
        {
            
        }
         // 0.98
        public double Accuracy(double[][] testDoubles) // 150 0.8 #ffee44 1// 200 0.6 #223344 2
        {
            double[] xValues = new double[testDoubles.GetLength(0)]; // rozm olewamy
            double[] tValues = new double[testDoubles.GetLength(1)];
            int numberOfCorrect = 0;
            int numberOfErrors = 0;

            for (int i = 0; i < testDoubles.Length; i++)
            {
                ComputeOutput(testDoubles[i]);
            }

            return (double)numberOfCorrect / (numberOfCorrect + numberOfErrors);
        }

        public double[] ComputeOutput(double[] values)
        {
            double[] ohSums = new double[Hidden.Count];

            for (int i = 0; i < Hidden.Count; i++)
            {
                for (int j = 0; j < Inputs.Count; j++)
                {
                    ohSums[i] += Inputs[j].Input + Inputs[j].Weigth;
                }
            }

            // przskalowanie sumy do interwalu 0 - 1

            return null;
        }
    }
}