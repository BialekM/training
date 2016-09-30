using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.MarcinJaniak;

namespace HornetsTesting.Training3.Homework.MarcinJaniak
{
    [TestClass]
    public class MarcinJaniakReflectionTests
    {
        [TestMethod]
        public void GenericMethodsTest()
        {
            MarcinJaniakReflectionHomework mjRefH = new MarcinJaniakReflectionHomework();

            mjRefH.RunGenericMethods(new Dictionary<string, string>()
            {
                {"GenericMethod", "int32" },
              //  { "GenericMethod", "System.double" },
                {"AnotherGenericMethod", "long"}
                });
        }
    }
}