using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training6.MachineLearning.Training;

namespace HornetsTesting.Training6.Train
{
    [TestClass]
    public class TrainerTest
    {
        [TestMethod]
        public void Test()
        {
            MlTrainer mlTr = new MlTrainer();

            mlTr.ReadFile();
        }
    }
}