using System;
using HornetsTraining.Training1.HomeWork.MichalMazur;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MichalMazur
{
    [TestClass]
    public class MichalMazurStringOperationsTest
    {
        private readonly MichalMazurStringOperations _michalMazurStringOperations = new MichalMazurStringOperations();

        [TestMethod]
        public void TestGetName()
        {
            Assert.AreEqual(_michalMazurStringOperations.GetName(), "Michal Mazur");
        }    
        
        [TestMethod]
        public void TestSubstring()
        {
             Assert.AreEqual(_michalMazurStringOperations.Substring("programowanie",4,5), "ramow");
             Assert.AreEqual(_michalMazurStringOperations.Substring("zaawansowane", 1, 3), "aaw");
             Assert.AreEqual(_michalMazurStringOperations.Substring("test", 1, 100), "est");

   
        }
        [TestMethod]
        public void TestPosistionInString()
        {
           Assert.AreEqual(_michalMazurStringOperations.PositionInString("jezykC", "yk"), 3);
           Assert.AreEqual(_michalMazurStringOperations.PositionInString("programowanie", "gra"), 3);

           Assert.AreEqual(_michalMazurStringOperations.PositionInString("test", "te"), 0);

        }
        [TestMethod]
        public void TestStringReplace()
        {
            Assert.AreEqual(_michalMazurStringOperations.StringReplace("programowanie", "gram", "kilogram"), "prokilogramowanie");

        }

    }
}
