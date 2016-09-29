using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTesting.Training1.HomeWork.LukaszSmierzchala.ClassesForInitializing;
using HornetsTesting.Training1.HomeWork.LukaszSmierzchala.FunctionsTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HornetsTesting.Training1.HomeWork.Assembly;
using Toci.HornetsTraining.Training1.HomeWork;
using HomeworkTest = HornetsTesting.Training1.Homework.HomeworkTest;

namespace HornetsTesting.Training1.HomeWork.LukaszSmierzchala
{
    [TestClass]
    public class LukaszSmierzchalaHomeworkTests : HomeworkTest
    {
        [TestMethod]
        public override void TestAllHomeworks()
        {
            var assemblyLoader = new AssemblyLoader();

            List<StringOperations> instances = assemblyLoader.GetTypesInstancesList<StringOperations>().ToList();

            var functionsToTest = new StringOperationsFunctionsTests();

            var testVariables = new FunctionsTestVariables();

            foreach (StringOperations instance in instances)
            {
                Console.WriteLine("\n" + instance.GetName());

                functionsToTest.Substring.Test(instance, testVariables.Substring, TestForSubstring);
                functionsToTest.PositionInString.Test(instance, testVariables.PositionInString, TestForPositionInString);
                functionsToTest.StringReplace.Test(instance, testVariables.StringReplace, TestForStringReplace);

                //functionsToTest.Substring.Test(instance, testVariables.Substring,
                //    (operations, substring) => 
                //    substring.Expected == operations.Substring(substring.Candidate, substring.Start, substring.Length));

                //functionsToTest.PositionInString.Test(instance, testVariables.PositionInString,
                //    (operations, positionInString) => 
                //    positionInString.Expected == operations.PositionInString(positionInString.Candidate, positionInString.Needle));

                //functionsToTest.StringReplace.Test(instance, testVariables.StringReplace, 
                //    (operations, stringReplace) =>
                //    stringReplace.Expected == operations.StringReplace(stringReplace.Candidate, stringReplace.Needle, stringReplace.ReplaceWith));
            }
        }


        private bool TestForSubstring(StringOperations operations, TestSubstring substring)
        {
            bool result = false;
            try
            {
                if (substring.Expected ==
                          operations.Substring(substring.Candidate, substring.Start, substring.Length))
                {
                    Console.WriteLine("Passed");
                    result = true;
                }
                else
                {
                    Console.WriteLine("!Failed");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(String.Format("Failed with Exception {0}", x.Message));
            }
            Console.WriteLine(String.Format("   For -> candidate: {0}, start: {1}, length: {2} ",
                                      substring.Candidate, substring.Start, substring.Length));

            return result;
        }


        private bool TestForPositionInString(StringOperations operations, TestPositionInString positionInString)
        {
            bool result = false;
            try
            {
                if (positionInString.Expected == operations.PositionInString(positionInString.Candidate, positionInString.Needle))
                {
                    Console.WriteLine("Passed");
                    result = true;
                }
                else
                {
                    Console.WriteLine("!Failed");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(String.Format("Failed with Exception {0}", x.Message));
            }
            Console.WriteLine(String.Format("   For -> candidate: {0}, needle: {1}",
                                      positionInString.Candidate, positionInString.Needle));

            return result;
        }


        private bool TestForStringReplace(StringOperations operations, TestStringReplace stringReplace)
        {
            bool result = false;
            try
            {
                if (stringReplace.Expected == operations.StringReplace(stringReplace.Candidate, stringReplace.Needle, stringReplace.ReplaceWith))
                {
                    Console.WriteLine("Passed");
                    result = true;
                }
                else
                {
                    Console.WriteLine("!Failed");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(String.Format("Failed with Exception {0}", x.Message));
            }
            Console.WriteLine(String.Format("   For -> candidate: {0}, needle: {1}, replaceWith: {2}",
                                      stringReplace.Candidate, stringReplace.Needle, stringReplace.ReplaceWith));

            return result;
        }
    }
}
