using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.PawelHanus;
using Toci.SeeSharpBasics.Test.TablesOperations;

namespace Toci.SeeSharpBasics.Test.PawelHanus
{
    [TestClass]
    public class PawelTablesOperationsTest : TablesOperationsTests
    {
        PawelHanusTableOperations test = new PawelHanusTableOperations();
        int[] input = new[] { 1, 3, 2, 4 };
        [TestMethod]
        public override void TestReversing()
        {

            int[] result = test.ReverseTable(input);

            Assert.AreEqual(result[0],4);
            Assert.AreEqual(result[1],2);
            Assert.AreEqual(result[2],3);
            Assert.AreEqual(result[3],1);

        }

        public  void TestBubbleSort()
        {
            int[] result2 = test.BubbleSort(input);
            Assert.AreEqual(result2[0], 4);
            Assert.AreEqual(result2[1], 2);
            Assert.AreEqual(result2[2], 3);
            Assert.AreEqual(result2[3], 4);
        }

        public void TestGetElementsFromTable()
        {
            int[] result3 = test.GetElementsFromTable(input,2);
            Assert.AreEqual(result3[0], 3);
            Assert.AreEqual(result3[1], 4);
        }

    }



}