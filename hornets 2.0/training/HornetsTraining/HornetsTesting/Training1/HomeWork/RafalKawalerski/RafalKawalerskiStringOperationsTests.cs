using HornetsTraining.Training1.HomeWork.RafalKawalerski;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.RafalKawalerski
{
    [TestClass]
    public class RafalKawalerskiStringOperationsTests
    {
        private readonly RafalKawalerskiStringOperations _rkStringOperations = new RafalKawalerskiStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_rkStringOperations.GetName(), "Rafal Kawalerski");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_rkStringOperations.Substring("AlaMaKota",3,2),"Ma");
            Assert.AreEqual(_rkStringOperations.Substring("House", 3, 5), "Za duza wartosc length");
        }
    }
}