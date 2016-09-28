using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.HornetsTraining.Training3.Homework;
using Toci.HornetsTraining.Training3.Homework.MichalMazur.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework
{
    [TestClass]
    public class MichalMazurHomeworkTestReflection
    {
        [TestMethod]
        public void TestReflection()
        {
            MichalMazurReflectionHomework test = new MichalMazurReflectionHomework();

            List<Dictionary<string, string>> ListOdDictionary = test.CreateExamples();

            test.RunGenericMethods(ListOdDictionary[0]);
            test.RunGenericMethods(ListOdDictionary[1],
                " HornetsTraining.Training3.Homework.MichalMazur.Reflection.ExamplesTypes", "Toci.HornetsTraining");
         }
    }
}