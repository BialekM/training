using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.PawelMarciniak;

namespace HornetsTesting.Training3.Homework.PawelMarciniak
{
    [TestClass]
    public class PawelMarciniakReflectionTest
    {
        [TestMethod]
        public void TestReflection()
        {
            PawelMarciniakReflectionHomework pmReflection = new PawelMarciniakReflectionHomework();

            Dictionary<string, string> types = new Dictionary<string, string>();
            types.Add("GenericMethod", "System.Int32");
            types.Add("GenericMethod", "System.Double");
            types.Add("GenericMethod", "System.Boolean");
            types.Add("AnotherGenericMethod", "System.Decimal");
            types.Add("AnotherGenericMethod", "System.Object");
            types.Add("AnotherGenericMethod", "System.String");

            pmReflection.RunGenericMethods(types);

        }

    }
}