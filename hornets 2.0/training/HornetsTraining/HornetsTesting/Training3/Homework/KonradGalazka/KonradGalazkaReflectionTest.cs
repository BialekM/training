using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework;
using Toci.HornetsTraining.Training3.Homework.KonradGalazka;

namespace HornetsTesting.Training3.Homework.KonradGalazka
{
    [TestClass]
    public class KonradGalazkaReflectionTest
    {
        
        [TestMethod]
        public void Test()
        {

            // nie działa jeszcze

            KonradGalazkaReflection KGTest = new KonradGalazkaReflection();
            Dictionary<string, string> types = new Dictionary<string, string>();
            types.Add("GenericMethod", "System.Int32");
            types.Add("GenericMethod", "System.Boolean");

            types.Add("AnotherGenericMethod", "System.Int32");
            types.Add("AnotherGenericMethod", "System.Boolean");

            KGTest.RunGenericMethods(types);
        }
    }
}