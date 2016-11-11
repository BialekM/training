using System;
using System.Collections.Generic;
using Toci.DevelopersLeasing.ModelHandlers.CoursesSearch;
using Toci.DevelopersLeasing.ModelHandlers.Instructors;
using Toci.DevelopersLeasing.ModelHandlers.RecentProjects;
using Toci.EmployeeLeasing.HandlerStrategies.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.OurInstructors;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.RecentProjects;

namespace Toci.DevelopersLeasing.ModelHandlers
{
    public static class Register
    {
        public static Dictionary<Type, Type> GetTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(ICoursesSearchHandler), typeof(ProgrammingCoursesSearchHandler) },
                {typeof(IInstructorsHandler), typeof(ProgrammingInstructorsHandler) },
                {typeof(IRecentProjectsHandler), typeof(ProgrammingRecentProjectsHandler) }
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