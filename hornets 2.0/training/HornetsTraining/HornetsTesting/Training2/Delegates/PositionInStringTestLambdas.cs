using System;
using System.Collections.Generic;
using System.Linq;
using HornetsTesting.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.Delegates
{
    [TestClass]
    public class PositionInStringTestLambdas
    {
        [TestMethod]
        public void Test()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>().ToList();

            RunTest(new PositionIsStringTest() { Candidate = "beatka", Needle = "eat", Position = 1 }, instances, (operations, position) => 
                position.Position == operations.PositionInString(position.Candidate, position.Needle));
        }

        private void RunTest(PositionIsStringTest test, List<StringOperations> instances, Func<StringOperations, PositionIsStringTest, bool> del)
        {
            //getName(instance);
            foreach (var instance in instances)
            {
                del(instance, test);
            }

        }
    }

    public class PositionIsStringTest
    {
        public int Position { get; set; }

        public string Candidate { get; set; }

        public string Needle { get; set; }
    }
}