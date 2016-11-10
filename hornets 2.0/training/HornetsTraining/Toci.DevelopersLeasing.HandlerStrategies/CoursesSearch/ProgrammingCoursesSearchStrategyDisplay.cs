using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.HandlerStrategies.CoursesSearch
{
    public class ProgrammingCoursesSearchStrategyDisplay : ProgrammingCoursesSearchStrategyBasic
    {
        public ProgrammingCoursesSearchStrategyDisplay(
            ICoursesSearchModel model, 
            ICoursesSearchBll coursesSearchBll, 
            IEndDateSearchParams endDateSearchParams, 
            IInstructorsSearchParams instructorsSearchParams, 
            ILevelSearchParams levelSearchParams, 
            IStartDateSearchParams startDateSearchParams, 
            ITopicsSearchParams topicsSearchParams) 
            : base(model, coursesSearchBll, endDateSearchParams, 
                  instructorsSearchParams, levelSearchParams, 
                  startDateSearchParams, topicsSearchParams)
        {
            
        }

        public override ICoursesSearchModel GetModel()
        {
            Model = base.GetModel();

            //Model.Courses.Courses.Add();

            return Model;
        }
    }
}