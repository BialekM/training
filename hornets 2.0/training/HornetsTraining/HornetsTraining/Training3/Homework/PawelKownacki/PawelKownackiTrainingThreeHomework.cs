using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Toci.HornetsTraining.Training3.Homework.PawelKownacki
{
    public class PawelKownackiTrainingThreeHomework : TrainingThreeHomework
    {
        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            keyMethodNameValueTypeName.AsParallel().WithDegreeOfParallelism(4).ForAll(
                (pair) => RunGenericMethod<GenericClasses>(pair.Key, pair.Value));
           


        }

        private void RunGenericMethod<TSource>(string methodName, string methodType)
        {
            MethodInfo genMethod = typeof(TSource).GetMethod(methodName).MakeGenericMethod(Type.GetType(methodType));
            TSource objectExecutedOn = Activator.CreateInstance<TSource>();
            genMethod.Invoke(objectExecutedOn, null);
            
            
        }
    }
}