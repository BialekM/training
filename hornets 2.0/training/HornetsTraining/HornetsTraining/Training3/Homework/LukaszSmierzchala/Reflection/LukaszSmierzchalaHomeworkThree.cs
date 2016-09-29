using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training3.Homework.LukaszSmierzchala.Reflection
{
    public class LukaszSmierzchalaHomeworkThree : TrainingThreeHomework
    {
        private readonly string _typeNameAndAssembly; // <-- works only for methods specified in this class
                                                      // to work for every, dictionary should contains class name

        public LukaszSmierzchalaHomeworkThree(string typeNameAndAssembly)
        {
            _typeNameAndAssembly = typeNameAndAssembly;
        }

        public override void RunGenericMethods(Dictionary<string, string> keyMethodNameValueTypeName)
        {
            object myObject = Activator.CreateInstance(Type.GetType(_typeNameAndAssembly));

            foreach (KeyValuePair<string, string> method in keyMethodNameValueTypeName)
            {
                MakeGenericMethod(new GenericMethodInfo(method.Key, _typeNameAndAssembly, method.Value))
                    .Invoke(myObject, null); //Without parameters!
            }
        }

        private MethodInfo MakeGenericMethod(GenericMethodInfo genericMethod)
        {
            MethodInfo method = Type.GetType(genericMethod.TypeNameAndAssembly).GetMethod(genericMethod.Name);
            List<Type> types = new List<Type>();

            foreach (string typeName in genericMethod.GenericTypes)
            {
                types.Add(Type.GetType(typeName));
            }

            return method.MakeGenericMethod(types.ToArray());
        }

    }
}
