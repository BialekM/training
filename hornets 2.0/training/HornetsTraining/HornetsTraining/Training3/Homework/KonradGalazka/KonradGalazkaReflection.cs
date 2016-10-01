using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Toci.HornetsTraining.Training3.Homework.KonradGalazka
{
    public class KonradGalazkaReflection : TrainingThreeHomework
    {
        public GenericClass GC = new GenericClass();

        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            
            foreach (var item in keyMethodNameValueTypeName)
            {
                var type = Type.GetType(item.Value); //pobierz Type
                var method = GC.GetType().GetMethod(item.Key); //pobierz klucz metody
                var gen = method.MakeGenericMethod(type);

                gen.Invoke(GC, null);
            }
            
        }
    }
}