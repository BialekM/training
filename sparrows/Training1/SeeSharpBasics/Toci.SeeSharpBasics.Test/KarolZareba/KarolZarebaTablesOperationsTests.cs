using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.BartekZapart;
using SeeSharpBasics.KarolZareba;
using Toci.SeeSharpBasics.Test.TablesOperations;

namespace Toci.SeeSharpBasics.Test.KarolZareba
{

    [TestClass]
    public class KarolZarebaTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public override void TestReversing()
        {
            TableOperations tableOperations = new KarolZarebaTablesOperations();
        }
    }
}