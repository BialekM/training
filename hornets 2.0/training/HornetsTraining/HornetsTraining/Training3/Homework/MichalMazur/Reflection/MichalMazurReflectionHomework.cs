using System;
using System.Collections.Generic;
using System.Reflection;

namespace HornetsTraining.Training3.Homework.MichalMazur.Reflection
{
    public class MichalMazurReflectionHomework : TrainingThreeHomework
    {
        

        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            throw new System.NotImplementedException();
        }

        public void CreateObject()
        {
            Type type = Type.GetType("HornetsTraining.Training3.Homework.GenericClass, Toci.HornetsTraining");
            var myGenericClass = Activator.CreateInstance(type);

            MethodInfo[] info = myGenericClass.GetType().GetMethods(BindingFlags.Instance);
        }
    }
}