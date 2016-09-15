using HornetsTraining.Training1.HomeWork.MateuszPorada;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MateuszPorada
{
    [TestClass]
    public class MateuszPoradaStringOperationsTest
    {
        private readonly MateuszPoradaStringOperations _matPorStrOp = new MateuszPoradaStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_matPorStrOp.GetName(), "Mateusz Porada");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_matPorStrOp.Substring("Drzewo",3,3), "ewo");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_matPorStrOp.PositionInString("Komputer", "put"), 3);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_matPorStrOp.StringReplace("AlaMaKota","Ma","i"),"AlaiKota");
            Assert.AreEqual(_matPorStrOp.StringReplace("Mateusz","at","de"),"Mdeeusz");
        }
    }
}