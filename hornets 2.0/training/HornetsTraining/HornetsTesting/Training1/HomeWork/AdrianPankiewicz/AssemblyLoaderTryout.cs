

using System;
using System.Diagnostics;
using HornetsTraining.Common;
using HornetsTraining.Training1.HomeWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training1.HomeWork.AdrianPankiewicz
{
    [TestClass]
    public class AssemblyLoaderTryout
    {
        [TestMethod]
        public void Tryout()
        {
            AssemblyLoader loader = new AssemblyLoader();
            var stringOperationInstances = loader.GetTypesInstancesList<StringOperations>();

            foreach (var instance in stringOperationInstances)
            {
                Console.WriteLine(instance.GetName());
            }
        }
    }
}