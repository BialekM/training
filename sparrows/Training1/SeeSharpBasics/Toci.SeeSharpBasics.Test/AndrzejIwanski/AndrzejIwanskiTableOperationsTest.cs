using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiTableOperationsTest
    {
        [TestMethod]
        public void BubblesortTest()
        {
            AndrzejIwanskiTableOperations andrzejTableOperationsTest = new AndrzejIwanskiTableOperations();

            int[] exampleTabInts = new[] {1, 3, 1, 5, 2, 4, 6, 0};

            int[] result = andrzejTableOperationsTest.BubbleSort(exampleTabInts);

            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[2], 1);
            Assert.AreEqual(result[4], 3);
        }
    }
}