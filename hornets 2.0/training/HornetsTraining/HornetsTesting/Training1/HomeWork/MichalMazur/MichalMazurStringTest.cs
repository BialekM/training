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
            List<AllTestClass> allTestClass=InitializeLists();
                foreach (var item in allTestClass)
                {
                    try
                    {
                        RunTests(item.positionIsStringTest, item.substringTest, item.repleaceTest, instances,
                            (operations, position) => position.Position == operations.PositionInString(position.Candidate, position.Needle),
                            (operations, substring) => substring.Result == operations.Substring(substring.Candidate, substring.Start, substring.Lenght),
                            (operations, repleacing) => repleacing.Result == operations.StringReplace(repleacing.Candidate, repleacing.Needle, repleacing.Repleace)
                            );
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

             /*pytanie: czy zamiast deklaracji w parametrach funkcji trzech osobnych func'ków, każdy dla innej 
              * metody(no bo metody mają inne sygnaturki), czy da sie zrobic tak, aby w parametrach podać jeden 
              * func, ale wywowałć tą funkcję RunTests 3 razy, za każdym razem podając w parametrze inna meotde ? */

        private void RunTests(PositionIsStringTest test, SubstringTest test2, RepleaceTest test3, List<StringOperations> instances, Func<StringOperations, PositionIsStringTest, bool> delPos,
            Func<StringOperations, SubstringTest, bool> delSub, Func<StringOperations, RepleaceTest, bool> delRep)
        {
            foreach (var instance in instances)
            {
                Debug.WriteLine(instance.GetName());
                Debug.WriteLine(test.Candidate + " : " + test.Needle + " -> " + test.Position + " result " + delPos(instance, test));
                Debug.WriteLine(test2.Candidate + " : " + test2.Start + " -> " + test2.Lenght + "  =  " + test2.Result + " result " + delSub(instance, test2));
                Debug.WriteLine(test3.Candidate + " : " + test3.Needle + " -> " + test3.Repleace + "  =  " + test3.Result + " result " + delRep(instance, test3));
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