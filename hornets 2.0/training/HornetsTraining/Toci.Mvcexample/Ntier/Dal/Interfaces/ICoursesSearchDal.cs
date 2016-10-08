using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;

namespace Toci.Mvcexample.Ntier.Dal.Interfaces
{
    public interface ICoursesSearchDal
    {
        CoursesDisplayModel GetCourses(CoursesSearchModel model);
    }
}