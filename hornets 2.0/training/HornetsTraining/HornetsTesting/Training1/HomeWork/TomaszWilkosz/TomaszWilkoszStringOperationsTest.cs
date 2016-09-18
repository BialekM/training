using System;
using System.Collections.Generic;
using System.Diagnostics;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HornetsTraining.Training1.HomeWork.TomaszWilkosz;

namespace HornetsTesting.Training1.Homework.TomaszWilkosz

{
    [TestClass]
    public class TomaszWilkoszStringOperationsTest
    {
        private TomaszWilkoszStringOperations _stringOperations= new TomaszWilkoszStringOperations();

        [TestMethod]
        public void GetNameTest()
        {
            Trace.WriteLine(_stringOperations.PositionInString("Aazra","ra"));
 
        }

         
    }
}