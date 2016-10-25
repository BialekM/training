using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeeSharpBasics.Training3.Homework.AndrzejIwanski;

namespace Toci.SeeSharpBasics.Test.Training3.HomeWork.AndrzejIwanski
{
    [TestClass]
    public class AndrzejIwanskiPeselValidatorTest
    {
        [TestMethod]
        public void Test()
        {
            AndrzejIwanskiPeselValidator aiPeselValidator = new AndrzejIwanskiPeselValidator();

            var result = aiPeselValidator.IsPeselValid("93012510757");
            var result2 = aiPeselValidator.IsPeselValid("93012510752");

        }
         
    }
}