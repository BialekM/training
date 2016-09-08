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

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_rkStringOperations.PositionInString("Hornets","rn"),2);
            Assert.AreEqual(_rkStringOperations.PositionInString("AlaMaKota","Kota"),5);
            Assert.AreEqual(_rkStringOperations.PositionInString("Catsanddogs","pig"), -1);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_rkStringOperations.StringReplace("CatsAndDogs","Dogs","Tigers"),"CatsAndTigers");
            Assert.AreEqual(_rkStringOperations.StringReplace("Beatka","atka","ta"),"Beta");
            Assert.AreEqual(_rkStringOperations.StringReplace("NoIdea","Id","Ik"),"NoIkea");
            Assert.AreEqual(_rkStringOperations.StringReplace("NoIdea","No","Yes"),"YesIdea");
        }
    }
}