using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Toci.HornetsTraining.Training3.Homework.WojtekSabat
{
    public class WojtekSabatTrainingThreeHomework : TrainingThreeHomework
    {
        private GenericClass _genericClass = new GenericClass();

        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            foreach (var pair in keyMethodNameValueTypeName)
            {
                var type = Type.GetType(pair.Value);
                var method = _genericClass.GetType().GetMethod(pair.Key);
                var genericMethod = method.MakeGenericMethod(type);
                
                genericMethod.Invoke(_genericClass, new object[0]);
            }
        }
    }
}