using HornetsTraining.Training2.ExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.ExtensionMetods
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void Test()
        {
            "".IsPalindrome(true);

            "".IAmExtensive();

            //2.IAmExtensive();
        }


        public void tableTest()
        {
            string[] test = new[] {""};

            test.Check<string>();

            test.IAmExtensive();
        }
    }
}