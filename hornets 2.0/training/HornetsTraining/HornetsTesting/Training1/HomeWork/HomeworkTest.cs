﻿using System.Collections.Generic;
using System.Diagnostics;
using Toci.HornetsTraining.Common;
using Toci.HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework
{
    [TestClass]
    public class HomeworkTest
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
            }
        }

        protected virtual void TestSubstring(StringOperations instance)
        {
            //bool substring = instance.Substring("bartek", 1, 3) == "art";

            List<SubstringTest> listOfCandidates = new List<SubstringTest>
            {
                new SubstringTest { Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest { Candidate = "bartek", Expected = "arte", Start = 1, Length = 4},
                new SubstringTest { Candidate = "beatka", Expected = "ka", Start = 4, Length = 2},
                new SubstringTest { Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest { Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
                new SubstringTest { Candidate = "bartek", Expected = "art", Start = 1, Length = 3},
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
    }

    class SubstringTest
    {
        public string Candidate { get; set; }

        public int Start { get; set; }

        public int Length { get; set; }

        public string Expected { get; set; }
    }
}