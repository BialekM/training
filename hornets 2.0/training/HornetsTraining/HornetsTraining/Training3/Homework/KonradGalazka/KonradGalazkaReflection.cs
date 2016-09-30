using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Toci.HornetsTraining.Training3.Homework.KonradGalazka
{
    public class KonradGalazkaReflection : TrainingThreeHomework
    {
        private GenericClass GC = new GenericClass();
        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            foreach (var obj in keyMethodNameValueTypeName)
            {
                var type = Type.GetType(obj.Value);
                var method = GC.GetType().GetMethod(obj.Key);
                var generic = method.MakeGenericMethod(type);

                generic.Invoke(GC, null);
            }
            //throw new System.NotImplementedException();
        }
    }
}