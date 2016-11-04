using System.Collections.Generic;
using System.Linq;

namespace Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch
{
    public interface ICoursesSearchDal
    {
        IQueryable<ICourseModel> GetCourses(ICoursesSearchParams searchParameters);
    }
}