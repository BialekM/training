using System;
using System.Collections.Generic;
using Toci.DevelopersLeasing.HandlerStrategies.CoursesSearch;
using Toci.EmployeeLeasing.HandlerStrategies.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.HandlerStrategies
{
    public static class Register
    {
        public static Dictionary<Type, Type> GetTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(ICoursesSearchHandlerStrategy), typeof(ProgrammingCoursesSearchStrategyBasic) }
            };
        }

        public static Dictionary<Type, Type> GetGenericTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {

            };
        }
    }
}