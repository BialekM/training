using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.training7.tpl;

namespace Toci.SeeSharpBasics.Test.training7.Tpl
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void test()
        {
            TplExample test = new TplExample();

            test.TplAsParalelShowDown();
        }
    }
}