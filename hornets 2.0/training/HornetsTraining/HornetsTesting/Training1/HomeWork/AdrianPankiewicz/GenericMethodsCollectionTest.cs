
using HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class GenericMethodsCollectionTest
    {
        [TestMethod]
        public void SwapTest()
        {
            int firstNumber = 10;
            int secondNumber = 15;
            GenericMethodsCollection<int>.Swap(ref firstNumber, ref secondNumber);
            Assert.AreEqual(15, firstNumber);
            Assert.AreEqual(10, secondNumber);
        }
    }
}