using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.BartekZapart;
using Toci.SeeSharpBasics.Test.TablesOperations;

namespace Toci.SeeSharpBasics.Test.BartekZapart
{
    [TestClass]
    public class BartekTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public override void TestReversing()
        {
            var tableOperations = new BartekTableOperations();
            var parameter = new[] {1, 2, 3, 4, 5};
            var result = tableOperations.ReverseTable(parameter); // 5 , 4, 3 ,2 ,1

            Assert.AreEqual(parameter[0], result[4]);
            Assert.AreEqual(parameter[1], result[3]);
            Assert.AreEqual(parameter[3], result[1]);
            //Assert.AreEqual
            //Assert.AreEqual
        }
    }
}