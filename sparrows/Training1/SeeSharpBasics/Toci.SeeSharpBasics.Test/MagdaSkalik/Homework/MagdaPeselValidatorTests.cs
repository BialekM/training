using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.MagdaSkalik.Homework;

namespace Toci.SeeSharpBasics.Test.MagdaSkalik.Homework
{
    [TestClass]
    public class MagdaPeselValidatorTests
    {
        [TestMethod]
        public void TestMethod()
        {
            MagdaPeselValidator test = new MagdaPeselValidator();
            
            var parameter = "810519029855";
            var result = test.IsPeselValid(parameter);


            Assert.AreEqual(true, result);
        }
    }
}
