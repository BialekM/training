using System.Diagnostics;
using HornetsTraining.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.Homework.SlawekKowal
{
    [TestClass]
    public class SlawekKStringTest
    {
        [TestMethod]
        public void AllStringOperationsTest()
        {
            AssemblyLoader loader = new AssemblyLoader();

            var allOperaions = loader.GetTypesInstancesList<StringOperations>();

            foreach (var stringOperations in allOperaions)
            {
                var name = stringOperations.GetName();
                var sString = stringOperations.Substring("Beatka", 1, 2);
                var posIn = stringOperations.PositionInString("Beatka", "tk");
                var repString = stringOperations.StringReplace("Beata", "ta", "tka");
                Debug.WriteLine(name + " - " + sString + " - " + posIn + " - " + repString);
            }
        }
    }
}