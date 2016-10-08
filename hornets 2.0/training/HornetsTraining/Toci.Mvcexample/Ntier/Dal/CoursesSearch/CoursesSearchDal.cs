using Toci.DesignPatterns.ExceptionHandling;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Dal.CoursesSearch
{
    public class CoursesSearchDal : DataAccessLayer, ICoursesSearchDal
    {
        public CoursesDisplayModel GetCourses(CoursesSearchModel model)
        {
            throw new TociDbApplicationException("_resources", 1, "text in english for a developer what happened {0}");
        }
    }
}