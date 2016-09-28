using System.Collections.Generic;
using Toci.HornetsTraining.Training3.Homework.LukaszCichon;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework.LukaszCichon
{
    [TestClass]
    public class LukaszCichonHomeworkReflectionTest
    {
        private Dictionary<string, string> keyMethodNameValueTypeName = new Dictionary<string, string>()
        {
            {"GenericMethodOne", "HornetsTraining.Training1.HomeWork.LukaszCichon.LukaszCichonStringOperations, Toci.HornetsTraining"},
            {"GenericMethodTwo", "System.Int32"},
            {"GenericMethodThree", "System.Double"},
            {"GenericMethodFour", "System.Single"},
            {"GenericMethodFive", "HornetsTraining.Training3.Homework.LukaszCichon.LukaszCichonHomework, Toci.HornetsTraining"},
            {"GenericMethodSix", "HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank.AliorBankTransferHandler, Toci.HornetsTraining"},
            {"GenericMethodSeven", "HornetsTraining.Training2.HomeWork.BankList, Toci.HornetsTraining"},
            {"GenericMethodEight", "HornetsTraining.Training2.Delegates.DelegateExample, Toci.HornetsTraining"},
            {"GenericMethodNine", "System.String"},
            {"GenericMethodTen", "HornetsTraining.Training3.Homework.LukaszCichon.GenericClasses, Toci.HornetsTraining"}
        };

        [TestMethod]
        public void RunGenericMethod()
        {
            LukaszCichonReflectionHomework testRun = new LukaszCichonReflectionHomework();

            testRun.RunGenericMethods(keyMethodNameValueTypeName);
        }
    }
}