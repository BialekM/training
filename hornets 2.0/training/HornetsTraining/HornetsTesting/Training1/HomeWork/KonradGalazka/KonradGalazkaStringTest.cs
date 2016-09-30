using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training1.HomeWork.KonradGalazka;

namespace HornetsTesting.Training1.Homework.KonradGalazka
{
    public class KonradGalazkaStringTest
    {
        private KonradGalazkaStringOperations KGTest = new KonradGalazkaStringOperations();
        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(KGTest.GetName(), "Konrad Gałązka");

            Assert.AreEqual(KGTest.PositionInString(KGTest.GetName(), "on"), 1);

            Assert.AreEqual(KGTest.StringReplace(KGTest.GetName(), "Gałązka", "Konrad"), "Konrad Konrad");

            Assert.AreEqual(KGTest.Substring(KGTest.GetName(), 3,3), "rad");
        }
    }
}