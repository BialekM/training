using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.HandlerStrategies.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.HandlerStrategies.CoursesSearch
{
    public abstract class ProgrammingCoursesSearchHandlerStrategy : ICoursesSearchHandlerStrategy
    {
        protected ICoursesSearchBll CoursesSearchBll;

        protected ProgrammingCoursesSearchHandlerStrategy(ICoursesSearchBll coursesSearchBll)
        {
            CoursesSearchBll = coursesSearchBll;
        }

        public abstract ICoursesSearchModel GetModel();
    }
}