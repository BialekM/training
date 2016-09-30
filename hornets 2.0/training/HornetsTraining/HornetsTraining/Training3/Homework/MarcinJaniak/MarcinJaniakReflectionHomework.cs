using System;
using System.Collections.Generic;
using System.Reflection;


namespace Toci.HornetsTraining.Training3.Homework.MarcinJaniak
{
    public class MarcinJaniakReflectionHomework : TrainingThreeHomework
    {
        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {

            Type type = Type.GetType("Toci.HornetsTraining.Training3.Homework.GenericClass, Toci.HornetsTraining");

            var genClass = Activator.CreateInstance(type);

            foreach (var item in keyMethodNameValueTypeName)
            {
                MethodInfo mInfo = genClass.GetType().GetMethod(item.Key);
                Type genericType = Type.GetType(item.Value);

                //TODO: cant be null
                MethodInfo generic = mInfo.MakeGenericMethod(genericType);

                generic.Invoke(genClass, null);
            }
        }
    }
}