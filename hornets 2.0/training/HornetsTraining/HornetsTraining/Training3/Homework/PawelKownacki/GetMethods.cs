using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Toci.HornetsTraining.Training3.Homework.PawelKownacki
{
    public class GetMethods
    {
        public static Dictionary<string,string> GetGenericMethods<TSource>()  
        {
            Dictionary<string,string> methodsAndTypes  = new Dictionary<string, string>();
            AddGenericMethods<TSource>(ref methodsAndTypes);
            return methodsAndTypes;

        }

        private static void AddGenericMethods<TSource>(ref Dictionary<string, string> tempGenericMethods)
        {
            List<MethodInfo> methods = typeof (TSource).GetMethods(BindingFlags.Instance | BindingFlags.Public).ToList();
            IEnumerable<MethodInfo> genMethods = methods.Where(method => method.IsGenericMethod);
            foreach (var genMethod in genMethods)
            {
                tempGenericMethods.Add(genMethod.Name,typeof(TSource).FullName);
            }
        }
    }
}