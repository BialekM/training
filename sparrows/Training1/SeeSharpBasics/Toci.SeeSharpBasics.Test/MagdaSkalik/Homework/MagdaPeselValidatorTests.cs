using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MagdaSkalik.Homework3;

namespace Toci.SeeSharpBasics.Test.MagdaSkalik.Homework
{
    [TestClass]
    public class MagdaPeselValidatorTests
    {
        [TestMethod]
        public void TestMethod()
        {
            MagdaPeselValidator test = new MagdaPeselValidator();
            
            var parameter = "81051902985";
            var result = test.IsPeselValid(parameter);


            Assert.AreEqual(true, result);
        }
    }
}
