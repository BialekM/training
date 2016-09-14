using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using HornetsTesting.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HornetsTesting.Training2.Delegates.MichalMazur
{
    [TestClass]
    public class MichalMazurStringOperationsTest
    {
        [TestMethod]
        public void  TestHomework()
        {
            List<StringOperations> homework = LoadAllHomework.LoadFromAssembly();

            LoadAllHomework.SubstringDelegate delSubstring = LoadAllHomework.AppendSubstringMethod(homework);
            delSubstring("komputer", 2, 3);





        }
    }
}