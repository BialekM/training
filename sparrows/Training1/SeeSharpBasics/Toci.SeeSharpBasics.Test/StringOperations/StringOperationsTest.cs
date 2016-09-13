using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Edwin;
using Toci.SeeSharpBasics.Test.Common;

namespace Toci.SeeSharpBasics.Test.StringOperations
{
    [TestClass]
    public class StringOperationsTest
    {
        [TestMethod]
        public void AllStringOperationsTest()
        {
            AssemblyLoader loader = new AssemblyLoader();

            var allOperaions = loader.GetTypesInstancesList<global::SeeSharpBasics.StringOperations>();

            foreach (var stringOperations in allOperaions)
            {
                var name = stringOperations.GetName();
            }
        }

        [TestMethod]
        public void EdwinLetterPositionInStringTest()
        {
            var edwin = new EdwinStringOperations();

            var position = edwin.LetterPositionInString("beatka123", 'a');

            Assert.AreEqual(position, 2);
        }
    }
}