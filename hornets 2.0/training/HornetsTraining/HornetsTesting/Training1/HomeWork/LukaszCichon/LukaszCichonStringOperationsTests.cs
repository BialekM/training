using System.Collections.Generic;
using System.Diagnostics;
using HornetsTesting.Common;
using HornetsTesting.Training1.Homework;
using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.LukaszCichon;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeworkTest = HornetsTesting.Training1.Homework.HomeworkTest;

namespace HornetsTesting.Training1.HomeWork.LukaszCichon
{
    [TestClass]
    public class LukaszCichonStringOperationsTests : HomeworkTest
    {
        [TestMethod]
        public override void TestAllHomeworks()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>();

            foreach (var instance in instances)
            {
                Debug.WriteLine("");
                Debug.WriteLine("**********************************");
                Debug.WriteLine(instance.GetName());

                TestSubstring(instance);
                Debug.WriteLine("-----------------------------------");

                TestPositionInString(instance);
                Debug.WriteLine("-----------------------------------");

                TestStringReplace(instance);
                Debug.WriteLine("-----------------------------------");
            }
        }

        [TestMethod]
        protected override void TestSubstring(StringOperations instance)
        {
        
          try
            {
                foreach (var candidate in listOfCandidatesSubstringTests)
                {
                    var substring = instance.Substring(candidate.Candidate, candidate.Start, candidate.Length) ==
                                    candidate.Expected;

                    if (substring)
                    {
                        Debug.WriteLine(string.Format("substring dla {0} dziala dobrze", candidate.Candidate));
                    }
                    else
                    {
                        Debug.WriteLine(string.Format("substring dla {0} dziala zle", candidate.Candidate));
                    }
                }
            }
            catch
            {
            }
        }
       

        [TestMethod]
        protected void TestPositionInString(StringOperations instance)
        {
            try
            {
                foreach (var candidate in listOfCandidatesPositionInStringTests)
                {
                    var positionInString = instance.PositionInString(candidate.Candidate, candidate.Needle) ==
                                           candidate.Expected;


                    if (positionInString)
                    {
                        Debug.WriteLine(string.Format("PositionInString dla {0} dziala dobrze", candidate.Candidate));
                    }
                    else
                    {
                        Debug.WriteLine(string.Format("PositionInString dla {0} dziala zle", candidate.Candidate));
                    }
                }
            }
            catch
            {
            }
        }


        [TestMethod]
        protected void TestStringReplace(StringOperations instance)
        {
            try
            {
                foreach (var candidate in listOfCandidatesStringReplaceTests)
                {
                    var stringReplaceTest =
                        instance.StringReplace(candidate.Candidate, candidate.Needle, candidate.ReplaceWit) ==
                        candidate.Expected;


                    if (stringReplaceTest)
                    {
                        Debug.WriteLine(string.Format("StringReplace dla {0} dziala dobrze", candidate.Candidate));
                    }
                    else
                    {
                        Debug.WriteLine(string.Format("StringReplace dla {0} dziala zle", candidate.Candidate));
                    }
                }
            }
           catch
           {
           }
        }

        
        List<SubstringTest> listOfCandidatesSubstringTests = new List<SubstringTest>
            {
                new SubstringTest {Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest {Candidate = "bartek", Expected = "arte", Start = 1, Length = 4},
                new SubstringTest {Candidate = "beatka", Expected = "ka", Start = 4, Length = 2},
                new SubstringTest {Candidate = "Beata", Expected = "eat", Start = 1, Length = 3},
                new SubstringTest {Candidate = "Beata", Expected = "Beata", Start = 0, Length = 5},
                new SubstringTest {Candidate = "Beata", Expected = "", Start = 4, Length = 0},
                new SubstringTest {Candidate = "Beata", Expected = "B", Start = 0, Length = 1},
            };

        List<PositionInStringTest> listOfCandidatesPositionInStringTests = new List<PositionInStringTest>
            {
                new PositionInStringTest {Candidate = "Beata", Expected = 2, Needle = "ata"},
                new PositionInStringTest {Candidate = "Beata", Expected = 1, Needle = "ea"},
                new PositionInStringTest {Candidate = "Beata", Expected = 0, Needle = "Bea"},
                new PositionInStringTest {Candidate = "Beata", Expected = 3, Needle = "ta"},
                new PositionInStringTest {Candidate = "Beata", Expected = 1, Needle = "eata"},
                new PositionInStringTest {Candidate = "homokulus", Expected = 1, Needle = "omokulus"},
            };

        List<StringReplaceTest> listOfCandidatesStringReplaceTests = new List<StringReplaceTest>
            {
                new StringReplaceTest {Candidate = "Beata", Expected = "Beatka", Needle = "at", ReplaceWit ="atk"},
                new StringReplaceTest {Candidate = "Hubert", Expected = "Hubercik", Needle = "t", ReplaceWit ="cik"},
                new StringReplaceTest {Candidate = "watert", Expected = "af", Needle = "Hub", ReplaceWit ="wat"},
                new StringReplaceTest {Candidate = "Beata", Expected = "Kacper", Needle = "Beata", ReplaceWit ="Kacper"},
                new StringReplaceTest {Candidate = "Beata", Expected = "Beata", Needle = "", ReplaceWit =""},
                new StringReplaceTest {Candidate = "misisipi", Expected = "mipipipi", Needle = "si", ReplaceWit ="pi"},
            };
    }
}


class SubstringTest
    {
        public string Candidate { get; set; }

        public int Start { get; set; }

        public int Length { get; set; }

        public string Expected { get; set; }
    }


      class PositionInStringTest
    {
        public string Candidate { get; set; }

        public string Needle { get; set; }

        public int Expected { get; set; }
    }


      class StringReplaceTest
    {
        public string Candidate { get; set; }

        public string Needle { get; set; }

        public string ReplaceWit { get; set; }

        public string Expected { get; set; }
    }

