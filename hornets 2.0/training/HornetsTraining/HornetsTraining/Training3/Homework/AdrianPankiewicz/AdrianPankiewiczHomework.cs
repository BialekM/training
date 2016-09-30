using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Toci.HornetsTraining.Training3.Homework.AdrianPankiewicz
{
    public class AdrianPankiewiczHomework : TrainingThreeHomework
    {
        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            keyMethodNameValueTypeName.AsParallel().WithDegreeOfParallelism(4).ForAll(
                (pair) => RunGenericMethod<GenericClass>(pair.Key, pair.Value) );
        }

        private void RunGenericMethod<TSourceType>(string methodName, string methodType)
        {
            MethodInfo genericMethod = typeof(TSourceType).GetMethod(methodName).MakeGenericMethod(Type.GetType(methodType));
            ParameterInfo[] parameters = genericMethod.GetParameters();
            RunGenericMethod<TSourceType>(genericMethod, parameters);
        }

        private void RunGenericMethod<TExecuteType>(MethodInfo genericMethod, ParameterInfo[] parameters)
        {
            TExecuteType objectExecutedOn = Activator.CreateInstance<TExecuteType>();

            genericMethod.Invoke(objectExecutedOn, GetParameterInstances(parameters));
        }

        private object[] GetParameterInstances(ParameterInfo[] parameters)
        {
            List<object> parameterInstances = new List<object>();

            parameters.AsParallel().ForAll((parameter) =>
            parameterInstances.Add(parameter.GetRealObject(new StreamingContext(StreamingContextStates.Clone))));

            return parameterInstances.ToArray();
        }

    }
}