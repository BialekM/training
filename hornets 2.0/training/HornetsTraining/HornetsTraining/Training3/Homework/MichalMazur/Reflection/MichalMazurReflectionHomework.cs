using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace HornetsTraining.Training3.Homework.MichalMazur.Reflection
{
    public class MichalMazurReflectionHomework : TrainingThreeHomework
    {
        private const string _nameSpace = "HornetsTraining.Training3.Homework.GenericClass";
        private const string _assembly = "Toci.HornetsTraining";
        private object myGenericClass;

        public MichalMazurReflectionHomework()
        {
            Type type = Type.GetType(_nameSpace + "," + _assembly);
            myGenericClass = Activator.CreateInstance(type);
        }


        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {

            foreach (var item in keyMethodNameValueTypeName)
            {
                var method = myGenericClass.GetType().GetMethod(item.Key);
                Type t = Type.GetType("System." + item.Value.First().ToString().ToUpper() + String.Join("", item.Value.Skip(1)));
                 method.MakeGenericMethod(t).Invoke(myGenericClass, null);
 
            }

        }
        public void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName, string nameSpace, string assembly)
        {

            foreach (var item in keyMethodNameValueTypeName)
            {
                var method = myGenericClass.GetType().GetMethod(item.Key);
                Type t = Type.GetType(nameSpace + "." + item.Value + "," + assembly);
                method.MakeGenericMethod(t).Invoke(myGenericClass, null);
                
            }

        }


        public List<Dictionary<string, string>> CreateExamples()
        {
            List<Dictionary<string, string>> listOfExamples = new List<Dictionary<string, string>>();
            listOfExamples.Add(new Dictionary<string, string>()
            {
                {"GenericMethod","double"},
                {"AnotherGenericMethod","decimal"},
            });
            listOfExamples.Add(new Dictionary<string, string>()
            {
               {"GenericMethod","TypeFirst"},
                {"AnotherGenericMethod","TypeSecond"},
            });

            return listOfExamples;

        }
    }
}