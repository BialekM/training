using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.LukaszSmierzchala.Reflection;

namespace HornetsTesting.Training3.Homework.LukaszSmierzchala.Reflection
{
    [TestClass]
    public class GenericMethodTest
    {
        [TestMethod]
        public void TestGenericMethod()
        {
            var dictionaries = new MethodsDictionaries();
            var genericMethodsInvoker = new LukaszSmierzchalaHomeworkThree(
                "Toci.HornetsTraining.Training3.Homework.GenericClass, Toci.HornetsTraining");

            foreach (Dictionary<string, string> dictionary in dictionaries.Dictionaries)
            {
                genericMethodsInvoker.RunGenericMethods(dictionary);
            }
        }
    }
}

