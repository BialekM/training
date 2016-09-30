using System.Collections.Generic;
using System.Diagnostics;
using Toci.HornetsTraining.Common;
using Toci.HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.PawelKownacki
{
    [TestClass]
    public class PawelKownackiStringOperationsTest

    {
        [TestMethod]
        public virtual void TestAllHomeworks()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>();

            foreach (var instance in instances)
            {
                Debug.WriteLine(instance.GetName());

                TestSubstring(instance);
                TestPositionInString(instance);
                //TestStringReplace(instance);
            }
        }

        protected virtual void TestSubstring(StringOperations instance)
        {
            //bool substring = instance.Substring("bartek", 1, 3) == "art";

            List<SubstringTest> listOfCandidates = new List<SubstringTest>
            {
                new SubstringTest {Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest {Candidate = "bartek", Expected = "arte", Start = 1, Length = 4},
                new SubstringTest {Candidate = "beatka", Expected = "ka", Start = 4, Length = 2},
                new SubstringTest {Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest {Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest {Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
            };

            foreach (var candidate in listOfCandidates)
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

        protected virtual void TestPositionInString(StringOperations instance)
        {
            List<PositionInStringTest> listOfCandidates = new List<PositionInStringTest>
            {
                new PositionInStringTest {Candidate = "bartek", Needle = "rt", Expected = 2},
                new PositionInStringTest {Candidate = "bartek", Needle = "ek", Expected = 4},
            }
            ;

            foreach (var candidate in listOfCandidates)
            {
                var positioninstrigtest = instance.PositionInString(candidate.Candidate,candidate.Needle) == candidate.Expected;

                if (positioninstrigtest)
                {
                    Debug.WriteLine(string.Format("PositionInString dla {0} dziala dobrze",candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("PositionInString dla {0} dziala zle", candidate.Candidate));
                }

            }
        }

        /*protected virtual void TestStringReplace(StringOperations instance)
        {
            List<StringReplaceTest> listOfCandidates = new List<StringReplaceTest>
            {
                new StringReplaceTest(){Candidate = "wujek" , Needle = "wuj",ReplaceWith = "ko",Expected = "kotek"}
            };

            foreach (var candidate in listOfCandidates)
            {
                var stringreplacetest =
                    instance.StringReplace(candidate.Candidate, candidate.Needle, candidate.ReplaceWith) ==
                    candidate.Expected;

                if(stringreplacetest)
                {
                    Debug.WriteLine(string.Format("StringReplace dla {0} dziala dobrze",candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("StringReplace dla {0} dziala zle", candidate.Candidate));
                }
            }
        }*/
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

        public string ReplaceWith { get; set; }

        public string Expected { get; set; }
    }
}