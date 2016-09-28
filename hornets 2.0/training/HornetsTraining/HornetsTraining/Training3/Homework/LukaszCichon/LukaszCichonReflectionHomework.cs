using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Toci.HornetsTraining.Training1.HomeWork;

namespace Toci.HornetsTraining.Training3.Homework.LukaszCichon
{
    public class LukaszCichonReflectionHomework : TrainingThreeHomework
    {
        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {

            Type type = Type.GetType("HornetsTraining.Training3.Homework.LukaszCichon.GenericClasses, Toci.HornetsTraining");
            
            var genClass = Activator.CreateInstance(type);
            
            foreach (var cell in keyMethodNameValueTypeName)
            {
                MethodInfo mInfo = genClass.GetType().GetMethod(cell.Key);
                Type genericType = Type.GetType(cell.Value);
                MethodInfo generic = mInfo.MakeGenericMethod(genericType);

                generic.Invoke(genClass, null);
            }
        }
    }
}