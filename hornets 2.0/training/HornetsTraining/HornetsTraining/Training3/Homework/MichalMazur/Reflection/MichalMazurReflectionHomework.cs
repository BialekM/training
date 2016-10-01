using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Toci.HornetsTraining.Training1.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training3.Homework.MichalMazur.Tpl;
using Toci.HornetsTraining.Training3.Reflection;
using Toci.HornetsTraining.Training3.Tpl;

namespace Toci.HornetsTraining.Training3.Homework.MichalMazur.Reflection
{
    public class MichalMazurReflectionHomework<TItem> : TrainingThreeHomework
    {

        private readonly object myGenericClass;

        public MichalMazurReflectionHomework()
        {

            Type type = Type.GetType(GetNameSpace<TItem>() + "," + GetAssembly<TItem>());
            myGenericClass = Activator.CreateInstance(type);
        }

        private string GetNameSpace<T>()
        {
            Type t = typeof(T);
            return t.FullName;

        }

        private string GetAssembly<T>()
        {
            Type t = typeof(T);
            return t.Assembly.ToString().Remove(t.Assembly.ToString().IndexOf(","));
        }

        private List<string> GetGenericMethodsList()
        {
            return myGenericClass.GetType()
                   .GetMethods()
                   .ToList()
                   .Where(mI => mI.IsGenericMethod)
                   .Select(m => m.Name).ToList();
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

        /* przeciążona wersja dla typów, któe w stringu mają podany fullname oraz nazwe assembly*/
        public void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName, bool customTypes)
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
            List<string> methodsList = GetGenericMethodsList();
            List<Dictionary<string, string>> listOfExamples = new List<Dictionary<string, string>>();

            listOfExamples.Add(new Dictionary<string, string>()
            {
                {methodsList[0],"double"},
                {methodsList[1],"decimal"},
            });
            listOfExamples.Add(new Dictionary<string, string>()
            {
                {methodsList[0], "char"},
                {methodsList[1], "string"},
            });
            /* dla swoich typów trzeba podać fullname oraz nazwe assembly*/
            listOfExamples.Add(new Dictionary<string, string>()
            {
                { methodsList[0], GetNameSpace<MichalMazurStringOperations>()+","+GetAssembly<MichalMazurStringOperations>()},
                {methodsList[1], GetNameSpace<MichalMazurTplHomework>()+","+GetAssembly<MichalMazurTplHomework>()},
            });
            listOfExamples.Add(new Dictionary<string, string>()
            {
                {methodsList[0],GetNameSpace<Entity>()+","+GetAssembly<Entity>() },
                {methodsList[1],GetNameSpace<Paralelism>()+","+GetAssembly<Paralelism>()},
            });


            return listOfExamples;

        }

    }
}