using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training6.MachineLearning.Populate;

namespace HornetsTesting.Training6.Populate
{
    [TestClass]
    public class GeneratorTest
    {
        [TestMethod]
        public void Test()
        {
            MlDataGenerator genewrator = new MlDataGenerator();

            genewrator.CreateFile();
        }
    }
}