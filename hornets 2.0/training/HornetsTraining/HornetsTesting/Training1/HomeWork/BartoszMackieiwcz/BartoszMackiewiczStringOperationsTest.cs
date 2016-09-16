using HornetsTraining.Training1.HomeWork.BartoszMackiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.BartoszMackieiwcz
{
    [TestClass]
    public class BartoszMackiewiczStringOperationsTest
    {
        private BartoszMackiewiczStringOperations Bartosz = new BartoszMackiewiczStringOperations();



        [TestMethod]
        public void SubstringTest()
        {
            Assert.AreEqual(4, Bartosz.PositionInString("GiewTelkiont", "Telki"));
        }

        [TestMethod]
        public void subst()
        {
            Assert.AreEqual(Bartosz.StringReplace("Warszklawoa", "klawo", "wa"), "Warszawa");
        }

    }
}


    
