using System;
using System.Collections.Generic;
using System.Reflection;

namespace Toci.HornetsTraining.Training3.Homework.PawelMarciniak
{
    public class PawelMarciniakReflectionHomework : TrainingThreeHomework
    {
        private const string Namespace = "Toci.HornetsTraining.Training3.Homework.GenericClass";
        private const string Assembly = "Toci.HornetsTraining";

        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            Type type = Type.GetType(Namespace + "," + Assembly);
            var genClass = Activator.CreateInstance(type);

            foreach (var item in keyMethodNameValueTypeName)
            {
                MethodInfo mInfo = item.GetType().GetMethod(item.Key);
                Type genType = Type.GetType(item.Value);
                MethodInfo genMeth = mInfo.MakeGenericMethod(genType);

                genMeth.Invoke(genClass, null);
            }


        }
    }
}