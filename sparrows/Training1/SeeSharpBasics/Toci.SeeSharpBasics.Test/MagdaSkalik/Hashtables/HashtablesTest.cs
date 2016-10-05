using SeeSharpBasics.MagdaSkalik.HashMaps;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toci.SeeSharpBasics.Test.MagdaSkalik.Hashtables
{
    [TestClass]
    public class HashtablesTest
    {
        [TestMethod]
        public void Test()
        {
            HashMapsExample example = new HashMapsExample();

            Hashtable result = example.GetCharactersCount("Magdalena");
        }
    }
}
