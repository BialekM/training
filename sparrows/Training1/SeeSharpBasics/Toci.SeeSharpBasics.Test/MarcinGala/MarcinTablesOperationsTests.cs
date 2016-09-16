using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MarcinGala;
using Toci.SeeSharpBasics.Test.TablesOperations;

namespace Toci.SeeSharpBasics.Test.MarcinGala
{
    [TestClass]
    public class MarcinTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public override void TestReversing()
        {

            MarcinTableOperations mg = new MarcinTableOperations();
            
            var parameter = new[] {5, 7, 3, 2,};
            var result = mg.BubbleSort(parameter);

            Assert.AreEqual(parameter[0], result[2]);

            //TableOperations mg = new TableOperations();

            //var parameter = new int[] {1, 2, 3, 4, 5};
            //var result = mg.ReverseTable(parameter);

            //Assert.AreEqual(parameter[0], result[4]);
            //Assert.AreEqual(parameter[1], result[3]);
            //Assert.AreEqual(parameter[3], result[1]);

        }
    }
}