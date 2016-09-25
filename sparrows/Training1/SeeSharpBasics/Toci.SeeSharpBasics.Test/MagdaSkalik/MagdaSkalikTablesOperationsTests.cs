using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.SeeSharpBasics.Test.TablesOperations;
using SeeSharpBasics.MagdaSkalik;

namespace Toci.SeeSharpBasics.Test.MagdaSkalik
{
    [TestClass]
    public class MagdaSkalikTablesOperationsTests : TablesOperationsTests
    {
        [TestMethod]
        public void BubbleSort()
        {
            MagdaSkalikTableOperations test = new MagdaSkalikTableOperations();

            var parameter = new[] { 3, 6, 2, 4, 1 };
            var result = test.BubbleSort(parameter);
            Assert.AreEqual(parameter[0], result[1]);

        }

        public override void TestReversing()
        {
            throw new NotImplementedException();
        }
    }
}
