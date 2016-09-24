<<<<<<< HEAD
﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MagdaSkalik;
=======
﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> 4b127e114a1a7e781fdbadda04db1a44345ce4a4
using Toci.SeeSharpBasics.Test.TablesOperations;

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
