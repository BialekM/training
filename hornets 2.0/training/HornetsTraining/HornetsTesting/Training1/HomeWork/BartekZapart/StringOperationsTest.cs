using HornetsTesting.Training1.HomeWork.Assembly;
using Toci.HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace a
{
    [TestClass]
    public class StringOperationsTest
    {
        [TestMethod]
        public void AllStringOperationsTest()
        {
            AssemblyLoader loader = new AssemblyLoader();

            var allOperaions = loader.GetTypesInstancesList<StringOperations>();

            foreach (var stringOperations in allOperaions)
            {
                var name = stringOperations.GetName();
            }
        }
    }
}