using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.HornetsTraining.Training3.Homework.LukaszSmierzchala.Reflection
{
    public class GenericMethodInfo
    {
        private const string Seperator = ", ";

        public string Name { get; private set; }

        public string TypeNameAndAssembly { get; private set; }

        public string[] GenericTypes { get; private set; }

        public GenericMethodInfo(string name, string typeNameAndAssembly, string[] genericTypes)
        {
            Name = name;
            TypeNameAndAssembly = typeNameAndAssembly;
            GenericTypes = genericTypes;
        }

        public GenericMethodInfo(string name, string typeNameAndAssembly, string genericType)
            : this(name, typeNameAndAssembly, new string[] { genericType })
        {

        }

        public GenericMethodInfo(string name, string typeName, string typeAssembly, string[] genericTypes)
            : this(name, typeName + Seperator + typeAssembly, genericTypes)
        {

        }

        public GenericMethodInfo(string name, string typeName, string typeAssembly, string genericType)
            : this(name, typeName + Seperator + typeAssembly, new string[] { genericType })
        {

        }
    }
}
