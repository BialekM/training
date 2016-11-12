using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Models.NewCoursesSearch.CourseDisplay;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public class CoursesSearchModelStrategyDisplayCourses : CoursesSearchModelStrategyBasic
    {
        private CoursesSearchModel _recentModel;

        public CoursesSearchModelStrategyDisplayCourses(
            ICoursesSearchBll coursesSearchBll,
            IEndDateSearchParams endDateSearchParams,
            IInstructorsSearchParams instructorsSearchParams,
            ILevelSearchParams levelSearchParams,
            IStartDateSearchParams startDateSearchParams,
            ITopicsSearchParams topicsSearchParams,
            CoursesSearchModel recentModel)
            : base(coursesSearchBll, endDateSearchParams, instructorsSearchParams,
                levelSearchParams, startDateSearchParams, topicsSearchParams)
        {
            _recentModel = recentModel;
        }

        public override CoursesSearchModel GetModel()
        {
            CoursesSearchModel model = base.GetModel();

            model.Courses = new CoursesDisplayModel()
            {
                Courses = new List<CourseDisplay>()
            };

            return model;
        }
    }
}