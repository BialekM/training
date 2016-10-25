using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.Training3.HomeWork.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiMoneyValueTest
    {
        [TestMethod]
        public void Test()
        {
            AndrzejIwnskiMoneyValue moneyValue = new AndrzejIwnskiMoneyValue();

            //string result = moneyValue.GetMoneyValue("1011");
            string result = moneyValue._partOfString("112");
        }
         
    }
}