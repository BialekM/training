using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using HornetsTraining.Training3.Homework.MichalMazur.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework
{
    [TestClass]
    public class MichalMazurHomeworktestReflection
    {
        [TestMethod]
        public void TestStringType()
        {
            var test = new MichalMazurReflectionHomework();

            List<Dictionary<string,string>> ListOdDictionary = test.CreateExamples();
            foreach (var item in ListOdDictionary)
            {
                test.RunGenericMethods(item);

            }
        }
    }
}