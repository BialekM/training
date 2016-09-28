using System;
using System.Reflection;
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;

namespace Toci.HornetsTraining.Training3.Reflection
{
    public class ReflectionExample
    {
        public void ReadProperties()
        {
            Entity ent = new Entity();

            PropertyInfo[] propInfos = ent.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var propInfo in propInfos)
            {
                propInfo.SetValue(ent, "dowolny string");
            }

            FieldInfo[] fields = ent.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField);

            foreach (var field in fields)
            {
                field.SetValue(ent, "jeszcze bardziej dowolny string");
            }
        }

        public void MakeGenericMethodExample()
        {
            Entity ent = new Entity();

            Type aliorType = typeof (AliorBankTransferHandler);

            MethodInfo mInfo = ent.GetType().GetMethod("GenericMethod");
            MethodInfo generic = mInfo.MakeGenericMethod(aliorType);

            generic.Invoke(ent, new [] { new AliorBankTransferHandler() });

            //ent.GenericMethod<aliorType>(new AliorBankTransferHandler());


        }
    }
}