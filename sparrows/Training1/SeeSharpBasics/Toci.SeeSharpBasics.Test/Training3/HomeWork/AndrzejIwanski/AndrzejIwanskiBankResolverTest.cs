using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.Training3.HomeWork.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiBankResolverTest
    {
        [TestMethod]
        public void Test()
        {
            AndrzejIwanskiBankResolver aiResolverTest = new AndrzejIwanskiBankResolver();

            var result = aiResolverTest.GetBankName("231020333333333333");
            Assert.AreEqual(result,"PKO BP");

            var result2 = aiResolverTest.GetBankName("0024900000000000000");
            Assert.AreEqual(result2, "Alior Bank");

            var result3 = aiResolverTest.GetBankName("2320701020333333333333");
            Assert.AreEqual(result3, "FCE Bank Polska");

            var result4 = aiResolverTest.GetBankName("77777777777");
            Assert.AreEqual(result4, null);
        }
    }
}