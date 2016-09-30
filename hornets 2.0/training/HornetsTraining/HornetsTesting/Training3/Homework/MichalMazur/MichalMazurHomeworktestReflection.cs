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
            MichalMazurReflectionHomework<GenericClass> test = new MichalMazurReflectionHomework<GenericClass>();

            List<Dictionary<string, string>> examples = test.CreateExamples();
 
            test.RunGenericMethods(examples[0]);
            test.RunGenericMethods(examples[1]);
            test.RunGenericMethods(examples[2],true);
            test.RunGenericMethods(examples[3],true);
        }
    }
}