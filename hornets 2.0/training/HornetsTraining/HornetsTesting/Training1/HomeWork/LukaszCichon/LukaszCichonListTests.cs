using System;
using System.Diagnostics;
using HornetsTraining.Training1.HomeWork.LukaszCichon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.LukaszCichon
{
    [TestClass]
    public class LukaszCichonListTests
    {
        [TestMethod]
        public void AddTest()
        {
            LukaszCichonList<int> myListOfInt = new LukaszCichonList<int>();

            try
            {
                myListOfInt.Add(9);
                myListOfInt.Add(10);
                myListOfInt.Add(13);
                myListOfInt.Add(5);

                myListOfInt.Remove(10);
                myListOfInt.Remove(9);
                myListOfInt.Remove(5);
                myListOfInt.Remove(111);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }
}