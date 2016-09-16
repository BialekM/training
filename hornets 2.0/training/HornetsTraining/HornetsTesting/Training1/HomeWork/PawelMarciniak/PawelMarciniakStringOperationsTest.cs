using HornetsTraining.Training1.HomeWork.PawelMarciniak;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HornetsTesting.Training1.Homework.PawelMarciniak
{
    [TestClass]
    public class PawelMarciniakStringOperationsTest
    {
        private readonly PawelMarciniakStringOperations _pawelMarciniakStringOperations = new PawelMarciniakStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Assert.AreEqual(_pawelMarciniakStringOperations.GetName(), "Pawel Marciniak");
        }

        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(_pawelMarciniakStringOperations.Substring("Testing", 2, 5), "string");
            Assert.AreEqual(_pawelMarciniakStringOperations.Substring("", 2, 5), "test");
            Assert.AreEqual(_pawelMarciniakStringOperations.Substring("test", 2, 8), "st");
        }

        [TestMethod]
        public void PositionInStringTest()
        {
            Assert.AreEqual(_pawelMarciniakStringOperations.PositionInString("Hornets", "et"), 4);
            Assert.AreEqual(_pawelMarciniakStringOperations.PositionInString("Symfonia", "on"), 4);
            Assert.AreEqual(_pawelMarciniakStringOperations.PositionInString("Pawel", "nic"), -1);
        }

        [TestMethod]
        public void StringReplaceTest()
        {
            Assert.AreEqual(_pawelMarciniakStringOperations.StringReplace("", "Dogs", "Tigers"), "");
            Assert.AreEqual(_pawelMarciniakStringOperations.StringReplace("test", "", "ta"), "");
            Assert.AreEqual(_pawelMarciniakStringOperations.StringReplace("Prasa", "P", "T"), "Trasa");
            Assert.AreEqual(_pawelMarciniakStringOperations.StringReplace("CatsAndDogs", "Dogs", "Cats"), "CatsAndCats");
        }
    }
}