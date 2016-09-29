using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HornetsTraining.Training3.Homework;
using HornetsTraining.Training3.Homework.MichalMazur.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework
{
    [TestClass]
    public class MichalMazurHomeworkTestReflection
    {
        [TestMethod]
        public void TestReflection()
        {
            MichalMazurReflectionHomework<GenericClass> test = new MichalMazurReflectionHomework<GenericClass>();

            List<Dictionary<string, string>> examples = test.CreateExamples();
            List<Dictionary<string, string>> customExamples = test.CreateExamplesOfCustomTypes();

            foreach (var item in examples)
            {
                test.RunGenericMethods(item);

            }
            foreach (var item in customExamples)
            {
                test.RunGenericMethodsWithCustomTypes(item);

            }
        }
    }
}