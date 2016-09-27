using System.Collections.Generic;
using HornetsTraining.Training3.Homework.MichalMazur.Tpl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Homework
{
    [TestClass]
    public class MichalMazurHomeworkTplTest
    {
        [TestMethod]
        public void testTpl()
        {
            var testTpl = new MichalMazurTplHomework();
            testTpl.DoTransfers();
        }
    }
}