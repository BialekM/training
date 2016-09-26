using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace HornetsTraining.Training3.Homework.MichalMazur.Reflection
{
    public class MichalMazurReflectionHomework : TrainingThreeHomework
    {


        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            throw new System.NotImplementedException();
        }

        public void CreateObject(string typ1, string typ2)
        {
           Type type = Type.GetType("HornetsTraining.Training3.Homework.GenericClass, Toci.HornetsTraining");

             var myGenericClass = Activator.CreateInstance(type);

            var info = myGenericClass.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);//.Where(m => m.IsGenericMethod).ToList();

            Type typ11 = Type.GetType("Entity");

            info[0].MakeGenericMethod(typ11);
            Dictionary<string, string> dict = new Dictionary<string, string>();


        }
    }
}