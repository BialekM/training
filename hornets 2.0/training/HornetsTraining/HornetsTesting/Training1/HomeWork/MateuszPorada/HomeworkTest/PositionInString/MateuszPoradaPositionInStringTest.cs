using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using HornetsTraining.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.MateuszPorada
{
    [TestClass]
    public class MateuszPoradaPositionInStringTest : PositionInStringTest
    {
        [TestMethod]
        public virtual void TestHomeworks()
        {
            AssemblyLoader all = new AssemblyLoader();

            var instances = all.GetTypesInstancesList<StringOperations>();

            foreach (var instance in instances)
            {
                Debug.WriteLine(instance.GetName());

                TestPositionInString(instance);
            }
        }

        public virtual void TestPositionInString(StringOperations instance)
        {
            List<PositionInStringTest> listOfCandidates = new List<PositionInStringTest>
            {
                new PositionInStringTest {Candidate = "Mateusz", Needle = "te", Start = 2, Expected = 2},
                new PositionInStringTest {Candidate = "Mateusz", Needle = "usz", Start = 4, Expected = 4},
                new PositionInStringTest {Candidate = "Samochod", Needle = "chod", Start = 4, Expected = 4},
                new PositionInStringTest {Candidate = "AlaMaKota", Needle = "Ma", Start = 3, Expected = 3},
                new PositionInStringTest {Candidate = "Bartek", Needle = "te", Start = 3, Expected = 3},
                new PositionInStringTest {Candidate = "Hornets", Needle = "net", Start = 3, Expected = 3}
            };

            foreach (var candidate in listOfCandidates)
            {
                var position = instance.PositionInString(candidate.Candidate, candidate.Needle) == candidate.Expected;
                if (position)
                {
                    Debug.WriteLine(string.Format("PositionInString dla {0} działa dobrze.", candidate.Candidate));
                }
                else
                {
                    Debug.WriteLine(string.Format("PositionInString dla {0} działa źle.", candidate.Candidate));
                }
            }
        }

        //class PositionInStringTest
        //{
            
        //}
    }
}