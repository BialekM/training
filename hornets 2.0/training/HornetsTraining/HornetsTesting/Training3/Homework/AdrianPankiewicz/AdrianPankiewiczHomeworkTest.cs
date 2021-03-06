﻿using Toci.HornetsTraining.Training3.Homework;
using Toci.HornetsTraining.Training3.Homework.AdrianPankiewicz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework.AdrianPankiewicz
{
    [TestClass]
    public class AdrianPankiewiczHomeworkTest
    {
        [TestMethod]
        public void RunGenericMethods()
        {
            AdrianPankiewiczHomework homework = new AdrianPankiewiczHomework();
            homework.RunGenericMethods(GenericMethodsCollector.GetHomeworkGenericsMethodsAndTypes<GenericClass>());
        }
    }
}