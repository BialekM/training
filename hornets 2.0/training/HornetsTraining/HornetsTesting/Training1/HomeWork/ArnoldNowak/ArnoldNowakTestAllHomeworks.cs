using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Common;
using Toci.HornetsTraining.Training1.HomeWork;

namespace HornetsTesting.Training1.Homework.ArnoldNowak
{
    [TestClass]
    public class ArnoldNowakTestAllHomeworks:HomeworkTest
    {
        [TestMethod]
        public new void TestAllHomeworks()
        {
            AssemblyLoader al = new AssemblyLoader();

            var instances = al.GetTypesInstancesList<StringOperations>();

            foreach (var instance in instances)
            {
                Debug.WriteLine(instance.GetName());

                TestSubstring(instance);
                TestPositionInString(instance);
                TestStringReplace(instance);
            }
        }

        protected override void TestSubstring(StringOperations instance)
        {
            //bool substring = instance.Substring("bartek", 1, 3) == "art";

            List<SubstringTest> listOfCandidates = new List<SubstringTest>
            {
                new SubstringTest() { Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest() { Candidate = "bartek", Expected = "arte", Start = 1, Length = 4},
                new SubstringTest() { Candidate = "beatka", Expected = "ka", Start = 4, Length = 2},
            };

            foreach (var candidate in listOfCandidates)
            {
                var substring = instance.Substring(candidate.Candidate, candidate.Start, candidate.Length) == candidate.Expected;

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

        protected void TestPositionInString(StringOperations instance)
        {
            List<StringTestExpanded> listOfCandidates = new List<StringTestExpanded>
            {
                new StringTestExpanded { Candidate = "bartek", Needle ="rte", PositionInStringResult = 2},
                //new StringTestExpanded { Candidate = "bartek", Needle ="rta", PositionInStringResult = -1},
            };

            foreach (var candidate in listOfCandidates)
            {
                var substring = instance.PositionInString( candidate.Candidate, candidate.Needle) == candidate.PositionInStringResult;

                if (substring)
                {
                    Debug.WriteLine(string.Format("positioninstring dla {0} dziala dobrze", candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("positioninstring dla {0} dziala zle", candidate.Candidate));
                }
            }
        }

        protected void TestStringReplace(StringOperations instance)
        {
            List<StringTestExpanded> listOfCandidates = new List<StringTestExpanded>
            {
                new StringTestExpanded { Candidate = "beata", Needle ="eat", ReplaceWith = "eatk", Expected = "beatka"},
                new StringTestExpanded { Candidate = "bartek zapart", Needle ="zapart", ReplaceWith = "kowalski", Expected = "bartek kowalski"},
            };

            foreach (var candidate in listOfCandidates)
            {
                var substring = instance.StringReplace(candidate.Candidate, candidate.Needle, candidate.ReplaceWith) == candidate.Expected;

                if (substring)
                {
                    Debug.WriteLine(string.Format("stringreplace dla {0} dziala dobrze", candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("stringreplace dla {0} dziala zle", candidate.Candidate));
                }
            }
        }
    }

    internal class StringTestExpanded : SubstringTest
    {
        public string Needle;
        public string ReplaceWith;
        public int PositionInStringResult;
    }
}