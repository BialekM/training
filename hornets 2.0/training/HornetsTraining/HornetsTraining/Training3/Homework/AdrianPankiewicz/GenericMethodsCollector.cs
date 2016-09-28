using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Toci.HornetsTraining.Training3.Homework.AdrianPankiewicz
{
    public static class GenericMethodsCollector
    {
        public static Dictionary<string, string> GetHomeworkGenericsMethodsAndTypes<TSourceType>()
        {
            Dictionary<string, string> methodsAndTypes = new Dictionary<string, string>();
            AddAllMethodsAndTypes<TSourceType>(ref methodsAndTypes);
            return methodsAndTypes;
        }

        private static void AddAllMethodsAndTypes<TSourceType>(ref Dictionary<string, string> toModify)
        {
            List<MethodInfo> methods = typeof(TSourceType).GetMethods(BindingFlags.Instance | BindingFlags.Public).ToList();
            IEnumerable<MethodInfo> genericMethods = methods.Where( method => method.IsGenericMethod);
            foreach (var genericMethod in genericMethods)
            {
                toModify.Add(genericMethod.Name, typeof(TSourceType).FullName);
            }
            
        }
        
    }
}