﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
<<<<<<< HEAD
=======
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator;
using Toci.Hornets.Sieradz.Quicksilver.TasksTrainingTwoQs;
>>>>>>> master
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;
using Toci.Hornets.Sieradz.UCantTouchThis.UndergroundTasks.PeselValidator;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{
    [TestClass]
    public class PeselValidatorTest
    {
        private static string testDirectory = @"..\..\Sieradz\TypowyAdam\";
        private static string assemblyName = "Toci.Hornets.Sieradz"; //TODO make it able to load more assemblies
        private static int iterationValue = 100;
        private static List<object> peselValidatorsList = new List<object>();
        private static List<List<string>> peselListsList = new List<List<string>>();
        private static Dictionary<string, Func<string, bool>> validatorFactory = new Dictionary<string, Func<string, bool>>();
        private static Dictionary<string, long> benchmarkTimes = new Dictionary<string, long>();
        
        [TestMethod]
        public void TestMethod1()
        {
            Stopwatch benchmark = new Stopwatch(); //TODO benchmark to separate method taking delegate
            benchmark.Start();
            GenerateListOfPeselLists(testDirectory);
            GenerateObjectList(assemblyName);
            GenerateMethodFactory();
            benchmark.Stop();
            benchmarkTimes.Add("Generating structures takes: ", benchmark.ElapsedMilliseconds);
            foreach (var isPeselValid in validatorFactory)
            {
                benchmark.Reset();
                benchmark.Start();
                for (int j = 0; j < iterationValue; j++) //TODO get rid of those loops
                {
                    foreach (var peselLists in peselListsList)
                    {
<<<<<<< HEAD
                        Assert.IsTrue(item.Value(testPesel));
                    }
                    foreach (string testPesel in invalidPeselLIst)
                    {
                        Assert.IsFalse(item.Value(testPesel));
                    }
                    foreach (string testPesel in uncommonCasesList)
                    {
                        Assert.IsFalse(item.Value(testPesel));
=======
                        for (int i = 0; i < peselLists.Count - 1; i++) //foreach (var pesel in peselLists)
                        {
                            Assert.AreEqual(isPeselValid.Value(peselLists[i]), (peselLists.Last() == "true"));
                        }

>>>>>>> master

                    }
                }
                benchmark.Stop();
                benchmarkTimes.Add(isPeselValid.Key, benchmark.ElapsedMilliseconds);
            }
            PrintBenchmarkTimes();
        }
        //TODO repair those static shit, make it more abstract
        private static void PrintBenchmarkTimes()
        {
            foreach (var benchmarkTime in benchmarkTimes)
            {
                Debug.Print("{0}: {1}ms", benchmarkTime.Key,benchmarkTime.Value);
            }
        }

        private static void GenerateMethodFactory()
        {
            foreach (PeselValidator o in peselValidatorsList)
            {
                validatorFactory.Add(o.GetNick(), o.IsPeselValid);
            }
        }
        private static void GenerateListOfPeselLists(string initialDirectory)
        {
            List<string> fileNames = new List<string>(Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @initialDirectory)));
            fileNames= fileNames.Where(s => s.Contains(".txt")).Where(s => s.Contains("Pesel")).ToList();
            foreach (var fileName in fileNames)
            {
                peselListsList.Add(GeneratePeselList(fileName));
            }
        }
        private static List<string> GeneratePeselList(string patch)
        {
            List<string> peselList = new List<string>();

<<<<<<< HEAD
             // "Nie bądź jak leń co śmierdzący jest!"
             //                                 UCCT

             { "TypowyAdam", new TypowyAdamPeselValidator().IsPeselValid },
             { "UCantTouchThisAutism", new UCantTouchThisAutismPeselValisator().IsPeselValid }
         };
=======
            using (StreamReader txtReader = new StreamReader(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @patch)))
            {
                while (txtReader.Peek() >= 0)
                {
                    peselList.Add(txtReader.ReadLine());
                }
            }
            return peselList;
        }

        private static void GenerateObjectList(string assemblyName)
        {

            Assembly myAssembly = AppDomain.CurrentDomain.Load(assemblyName);
            foreach (var type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(PeselValidator))))
            {
                peselValidatorsList.Add((PeselValidator) Activator.CreateInstance(type));
            }   
        }
>>>>>>> master
    }


}
