using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MarcinGala;


namespace Toci.SeeSharpBasics.Test.MarcinGala
{
    [TestClass]
    public class MarcinGalaStringOperationsTests 
    {
        [TestMethod]
        public void Test()
        {
            MarcinGalaStringOperations mg = new MarcinGalaStringOperations();


            //mg.Substring("Maciejka", 4, 5);
            mg.Substring("Maciejka", 1, 1);
            //mg.StringReplace("Maciejka", "ac", "rcin");

        }

    }
}