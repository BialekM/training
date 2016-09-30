using System;
using System.Reflection;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training3.Homework;
using Toci.HornetsTraining.Training3.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HornetsTesting.Training3.Reflection
{
    [TestClass]
    public class ReflectionTests
    {
        [TestMethod]
        public void TestPRopertyReadingReflection()
        {
            ReflectionExample example = new ReflectionExample();

            example.ReadProperties();
        }

        [TestMethod]
        public void TestMakeGenericMethod()
        {
            ReflectionExample example = new ReflectionExample();

            example.MakeGenericMethodExample();
        }

        [TestMethod]
        public void TestStringType()
        {
            Type type = Type.GetType("HornetsTraining.Training3.Homework.GenericClass, Toci.HornetsTraining");

            var genClass = Activator.CreateInstance(type);

            MethodInfo mInfo = genClass.GetType().GetMethod("GenericMethod");
            MethodInfo generic = mInfo.MakeGenericMethod(type);

            generic.Invoke(genClass, null);
        }
    }
}