using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.DevelopersLeasing.Bll.CoursesSearch;
using Toci.DevelopersLeasing.Dal.CoursesSearch;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll
{
    public static class Register
    {
        public static Dictionary<Type, Type> GetTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(ICoursesSearchBll), typeof(ProgrammingCoursesSearchBll) },
                {typeof(IEndDateSearchParams), typeof(ProgrammingCoursesEndDateSearchParams) },
                {typeof(IInstructorsSearchParams), typeof(ProgrammingCoursesInstructorsSearchParams) },
                {typeof(ILevelSearchParams), typeof(ProgrammingCoursesLevelsSearchParams) },
                {typeof(IStartDateSearchParams), typeof(ProgrammingCoursesStartDateSearchParams) },
                {typeof(ITopicsSearchParams), typeof(ProgrammingCoursesTopicsSearchParams) }
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
