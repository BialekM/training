using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiStringOperationsTest
    {
        private AndrzejIwanskiStringOperations AndrzejIwanskiTests = new AndrzejIwanskiStringOperations();

        [TestMethod]
        public void GetNameTesting()
        {
            Debug.WriteLine(AndrzejIwanskiTests.GetName());
        }

        [TestMethod]
        public void SubstringTesting()
        {
            var test1 = AndrzejIwanskiTests.Substring("andrzej", 0, 3);
            var test2 = AndrzejIwanskiTests.Substring("andrzej", 1, 5);
            var test3 = AndrzejIwanskiTests.Substring("andrzej", 0, 7);
            var test4 = AndrzejIwanskiTests.Substring("andrzej", 6, 1);
            var test5 = AndrzejIwanskiTests.Substring("andrzej", 3, 3);

            Assert.AreEqual(test1, "and");
            Assert.AreEqual(test2, "ndrze");
            Assert.AreEqual(test3, "andrzej");
            Assert.AreEqual(test4, "j");
            Assert.AreEqual(test5, "rze");
        }

        
        [TestMethod]
        public void StringReplaceTesting()
        {
            var test1 = AndrzejIwanskiTests.StringReplace("andrzej", "ndr", "iwan");
            var test2 = AndrzejIwanskiTests.StringReplace("andrzej", "ndr", "");
            var test3 = AndrzejIwanskiTests.StringReplace("andrzej", "ej", "iwiwiwiwiw");
            var test4 = AndrzejIwanskiTests.StringReplace("andrzej", "a", "ala ma kota");
            var test5 = AndrzejIwanskiTests.StringReplace("andrzej", "ndrze", "PK");

            Assert.AreEqual(test1, "aiwanzej");
            Assert.AreEqual(test2, "azej");
            Assert.AreEqual(test3, "andrziwiwiwiwiw");
            Assert.AreEqual(test4, "ala ma kotandrzej");
            Assert.AreEqual(test5, "aPKj");
        }

    }
}