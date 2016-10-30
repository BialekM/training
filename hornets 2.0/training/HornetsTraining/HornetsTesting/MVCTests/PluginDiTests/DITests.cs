using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.MVCTests.PluginDiTests
{
    [TestClass]
    public class DITests
    {
        [TestMethod]
        public void TestDI()
        {
            var exampleInstance = ExampleAutofacResolve.ResolveType<ExampleClass>();
            exampleInstance.InvokeIt();
        }
    }
}
