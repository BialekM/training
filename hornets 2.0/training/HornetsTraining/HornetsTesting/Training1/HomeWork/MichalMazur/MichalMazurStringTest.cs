using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using HornetsTesting.Training1.HomeWork.Assembly;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training2.Delegates.MichalMazur
{
    [TestClass]
    public class MichalMazurStringTest
    {

        [TestMethod]
        public void Test()
        {
            AssemblyLoader al = new AssemblyLoader();
            var instances = al.GetTypesInstancesList<StringOperations>().ToList();
            List<AllTestClass> allTestClass = InitializeLists();
            foreach (var item in allTestClass)
            {
                try
                {

                    RunTests("position test", item, instances, (operations, test) =>
                       test.positionIsStringTest.Position == operations.PositionInString(test.positionIsStringTest.Candidate, test.positionIsStringTest.Needle) ?
                        (test.positionIsStringTest.Candidate + " : " + test.positionIsStringTest.Needle + " = " + test.positionIsStringTest.Position + "  test passed") : "failed");

                    RunTests("substring test", item, instances, (operations, test) =>
                       test.substringTest.Result == operations.Substring(test.substringTest.Candidate, test.substringTest.Start, test.substringTest.Lenght) ?
                       (test.substringTest.Candidate + " : " + test.substringTest.Start + " -> " + test.substringTest.Lenght + " = " + test.substringTest.Result + "  test passed") : "failed");

                    RunTests("repleacing test", item, instances, (operations, test) =>
                        test.repleaceTest.Result == operations.StringReplace(test.repleaceTest.Candidate, test.repleaceTest.Needle, test.repleaceTest.Repleace) ?
                        (test.repleaceTest.Candidate + " : " + test.repleaceTest.Needle + " -> " + test.repleaceTest.Repleace + " = " + test.repleaceTest.Result + "  test passed") : "failed");


                }
                catch
                {
                }
            }
        }

        private List<AllTestClass> InitializeLists()
        {

            List<AllTestClass> allTestClass = new List<AllTestClass>()
                {
                    new AllTestClass()
                    {
                        positionIsStringTest = new PositionIsStringTest()
                        {
                            Candidate = "komputer",
                            Needle = "mpu",
                            Position = 2
                        },
                        substringTest = new SubstringTest()
                        {
                            Candidate = "komputer",
                            Start = 1,
                            Lenght = 6,
                            Result = "ompute"

                        },
                        repleaceTest = new RepleaceTest()
                        {
                            Candidate = "komputer",
                            Needle = "mpu",
                            Repleace = "hto",
                            Result = "kohtoter"
                        },
                    },
                    new AllTestClass()
                    {
                        positionIsStringTest = new PositionIsStringTest()
                        {
                            Candidate = "programowanie",
                            Needle = "gram",
                            Position = 3
                        },
                        substringTest = new SubstringTest()
                        {
                            Candidate = "programowanie",
                            Start = 4,
                            Lenght = 5,
                            Result = "ramow"

                        },
                        repleaceTest = new RepleaceTest()
                        {
                            Candidate = "programowanie",
                            Needle = "gram",
                            Repleace = "tona",
                            Result = "protonaowanie"
                        },


                    }
                };

            return allTestClass;

        }

        private void RunTests(string testName, AllTestClass test, List<StringOperations> instances, Func<StringOperations, AllTestClass, string> del)
        {

            foreach (var instance in instances)
            {
                Debug.WriteLine(testName + " for " + instance.GetName() + " | " + del(instance, test));

            }
        }

    }

    public class AllTestClass
    {
        public PositionIsStringTest positionIsStringTest;
        public SubstringTest substringTest;
        public RepleaceTest repleaceTest;
    }

    public class PositionIsStringTest
    {
        public int Position { get; set; }

        public string Candidate { get; set; }

        public string Needle { get; set; }


    }
    public class SubstringTest
    {

        public string Candidate { get; set; }

        public int Start { get; set; }

        public int Lenght { get; set; }

        public string Result { get; set; }
    }

    public class RepleaceTest
    {

        public string Candidate { get; set; }

        public string Needle { get; set; }


        public string Repleace { get; set; }


        public string Result { get; set; }
    }

}