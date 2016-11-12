using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.DevelopersLeasing.Dal.CoursesSearch;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Dal
{
    public static class Register
    {
        public static Dictionary<Type, Type> GetTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(ICoursesSearchDal), typeof(ProgrammingCoursesSearchDal) },
                {typeof(ICourseModel), typeof(ProgrammingCourseModel) },
                {typeof(ICoursesSearchParams), typeof(ProgrammingCoursesSearchParams) }
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
