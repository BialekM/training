using System.Collections.Generic;

namespace HornetsTraining.Training3.Homework.AdrianPankiewicz
{
    public static class GenericMethodsCollector
    {
        public static Dictionary<string, string> GetHomeworkGenericsMethodsAndTypes()
        {
            Dictionary<string, string> methodsAndTypes = new Dictionary<string, string>();
            AddAllMethodsAndTypes(ref methodsAndTypes);
            return methodsAndTypes;
        }

        private static void AddAllMethodsAndTypes(ref Dictionary<string, string> toModify)
        {
            //toModify.Add();
        }
        
    }
}