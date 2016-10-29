using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch
{
    public interface ICoursesSearch
    {
        IEnumerable<ICourseSearchModel> GetCourses(ICourseSearchParams searchParameters);
    }
}