using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Dal.CoursesSearch
{
    public class ProgrammingCoursesSearch : ICoursesSearch
    {
        public IEnumerable<ICourseSearchModel> GetCourses(ICourseSearchParams searchParameters)
        {
            return new List<ICourseSearchModel>();
        }
    }
}
