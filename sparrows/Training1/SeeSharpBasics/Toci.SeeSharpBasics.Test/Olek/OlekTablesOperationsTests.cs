using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.SeeSharpBasics.Test.TablesOperations;

namespace Toci.SeeSharpBasics.Test.Olek
{
    [TestClass]
    public class OlekTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public override void TestReversing() // test
        {
                                    //ponizej bylo bez prefixu Olek i bylo nie halo...
            var tableOperations = new OlekTablesOperationsTests();//hmmm.....
            
            var parameter = new[] {1, 2, 3, 4, 5};
           // var result = tableOperations.ReverseTable(parameter); //5, 4, 3, 2, 1
                                       //...może przestrzeń nazw???
                                        // using SeeSharpBasics.Olek  ???????
            // TablesOperations.ReverseTable()

          //  Assert.AreEqual(parameter[0], result[4]);
          //  Assert.AreEqual(parameter[2], result[2]);
          //  Assert.AreEqual(parameter[3], result[1]);
          //  Assert.AreEqual(parameter[4], result[0]);
            //Assert.AreEqual();

        }

    }
}