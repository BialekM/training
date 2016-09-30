using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.WojtekSabat;

namespace HornetsTesting.Training3.Homework.WojtekSabat
{
    [TestClass]
    public class WojtekSabatReflectionTest
    {
        [TestMethod]
        public void Reflectiontest()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"GenericMethod","HornetsTesting.Training3.Homework.WojtekSabat.WojtekSabatReflectionTest, HornetsTesting" },
                {"AnotherGenericMethod", "Toci.HornetsTraining.Training3.Reflection.Entity" }
            };

            WojtekSabatTrainingThreeHomework wojtekSabatHomework = new WojtekSabatTrainingThreeHomework();
            wojtekSabatHomework.RunGenericMethods(dict);
        }
    }
}