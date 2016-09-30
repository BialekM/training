using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training2.HomeWork;

namespace HornetsTesting.Training3.Homework.LukaszSmierzchala.Reflection
{
    public class MethodsDictionaries
    {
        public List<Dictionary<string, string>> Dictionaries { get; private set; }

        public MethodsDictionaries()
        {
            Dictionaries = new List<Dictionary<string, string>>()
            {
                new Dictionary<string, string>()
                {
                    { "GenericMethod", GetName(typeof(string)) },
                    { "AnotherGenericMethod", GetName(typeof(TransferHandler)) }
                }
            };
        }

        private string GetName(Type type)
        {
            return type.AssemblyQualifiedName;
        }
    }
}
