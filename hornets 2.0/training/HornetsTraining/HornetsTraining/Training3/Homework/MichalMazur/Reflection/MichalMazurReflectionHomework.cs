using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace HornetsTraining.Training3.Homework.MichalMazur.Reflection
{
    public class MichalMazurReflectionHomework<TItem> : TrainingThreeHomework
    {

        private object myGenericClass;

        public MichalMazurReflectionHomework()
        {

            Type type = Type.GetType(GetNameSpace<TItem>() + "," + GetAssembly<TItem>());
            myGenericClass = Activator.CreateInstance(type);
        }

        public string GetNameSpace<T>()
        {
            Type t = typeof(T);
            return t.FullName;

        }

        private string GetAssembly<T>()
        {
            Type t = typeof(T);
            return t.Assembly.ToString().Remove(t.Assembly.ToString().IndexOf(","));
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


        public void RunGenericMethodsWithCustomTypes(Dictionary<string, string> keyMethodNameValueTypeName)
        {


            foreach (var item in keyMethodNameValueTypeName)
            {
                var method = myGenericClass.GetType().GetMethod(item.Key);
                Type t = Type.GetType(item.Value);
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
               {"GenericMethod","char"},
                {"AnotherGenericMethod","string"},
            });

            return listOfExamples;

        }
        public List<Dictionary<string, string>> CreateExamplesOfCustomTypes()
        {
            List<Dictionary<string, string>> listOfExamples = new List<Dictionary<string, string>>();
            listOfExamples.Add(new Dictionary<string, string>()
            {
                { "GenericMethod", "HornetsTraining.Training3.Homework.MichalMazur.Reflection.ExamplesTypes.TypeFirst, Toci.HornetsTraining"},
                {"AnotherGenericMethod", "HornetsTraining.Training3.Homework.MichalMazur.Reflection.ExamplesTypes.TypeSecond, Toci.HornetsTraining"},
            });
            listOfExamples.Add(new Dictionary<string, string>()
            {
                {"GenericMethod","HornetsTraining.Training3.Reflection.Entity, Toci.HornetsTraining"},
                {"AnotherGenericMethod","Toci.HornetsTraining.Training3.Tpl.Paralelism, Toci.HornetsTraining"},
            });

            return listOfExamples;

        }
    }
}