using System;
using System.Collections.Generic;
using System.Diagnostics;
using HornetsTraining.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MateuszPorada.HomeworkTest.StringReplace
{
    [TestClass]
    public class MateuszPoradaStringReplaceTest : StringReplaceTest
    {
        [TestMethod]
        public virtual void TestHomeworks()
        {
            AssemblyLoader all = new AssemblyLoader();

            var instances = all.GetTypesInstancesList<StringOperations>();

            foreach (var instance in instances)
            {
                Debug.WriteLine(instance.GetName());

                TestStringReplace(instance);
            }
        }

        public virtual void TestStringReplace(StringOperations instance)
        {
            List<StringReplaceTest> listOfCandidates = new List<StringReplaceTest>
            {
                new StringReplaceTest {Candidate = "Mateusz", Needle = "te", ReplaceWith = "TY", Start = 2, Length = 2, Expected = "MaTYusz"}
                //new PositionInStringTest {Candidate = "Mateusz", Needle = "usz", Start = 4, Expected = 4},
                //new PositionInStringTest {Candidate = "Samochod", Needle = "chod", Start = 4, Expected = 4},
                //new PositionInStringTest {Candidate = "AlaMaKota", Needle = "Ma", Start = 3, Expected = 3},
                //new PositionInStringTest {Candidate = "Bartek", Needle = "te", Start = 3, Expected = 3},
                //new PositionInStringTest {Candidate = "Hornets", Needle = "net", Start = 3, Expected = 3}
            };

            foreach (var candidate in listOfCandidates)
            {
                var position = instance.StringReplace(candidate.Candidate, candidate.Needle, candidate.ReplaceWith) == candidate.Expected;
                if (position)
                {
                    Debug.WriteLine(string.Format("StringReplace dla {0} działa dobrze.", candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("StringReplace dla {0} działa źle.", candidate.Candidate));
                }
            }
        }
    }
}