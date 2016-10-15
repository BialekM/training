using System.Collections.Generic;

namespace Toci.HornetsTraining.Training6.NeuralNetworks
{
    public class Perceptron
    {
        public double Weigth { get; set; }
        public double ActivationTreshold { get; set; }
        public double Bias { get; set; }
        public double Gradient { get; set; }
        public double BiasGradient { get; set; }
        public double Input { get; set; }

        public Dictionary<string, Perceptron> Neighbours { get; set; }

        public Perceptron()
        {
            InitializeWeight();
        }

        protected void InitializeWeight()
        {

        }
    }

    
}