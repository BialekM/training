using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.HornetsTraining.Training3.Homework.PawelKownacki;

namespace HornetsTesting.Training3.Homework.PawelKownacki
{
    [TestClass]
    public class ReflectionHomeworkTest
    {

       

        [TestMethod]
        public void ReflectionTest()
        {
            PawelKownackiTrainingThreeHomework homeworkTest = new PawelKownackiTrainingThreeHomework();

            homeworkTest.RunGenericMethods(GetMethods.GetGenericMethods<GenericClasses>());


        }
    }
}