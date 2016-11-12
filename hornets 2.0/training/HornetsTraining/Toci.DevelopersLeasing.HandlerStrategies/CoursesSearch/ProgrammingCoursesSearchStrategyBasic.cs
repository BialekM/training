using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.HandlerStrategies.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.HandlerStrategies.CoursesSearch
{
    public class ProgrammingCoursesSearchStrategyBasic : ProgrammingCoursesSearchHandlerStrategy
    {
        protected ICoursesSearchModel Model;

        private IEndDateSearchParams _endDateSearchParams;
        private IInstructorsSearchParams _instructorsSearchParams;
        private ILevelSearchParams _levelSearchParams;
        private IStartDateSearchParams _startDateSearchParams;
        private ITopicsSearchParams _topicsSearchParams;

        public ProgrammingCoursesSearchStrategyBasic(
            ICoursesSearchModel model,
            ICoursesSearchBll coursesSearchBll,
            IEndDateSearchParams endDateSearchParams,
            IInstructorsSearchParams instructorsSearchParams,
            ILevelSearchParams levelSearchParams,
            IStartDateSearchParams startDateSearchParams,
            ITopicsSearchParams topicsSearchParams) 
            : base(coursesSearchBll)
        {
            Model = model;

            _endDateSearchParams = endDateSearchParams;
            _instructorsSearchParams = instructorsSearchParams;
            _levelSearchParams = levelSearchParams;
            _startDateSearchParams = startDateSearchParams;
            _topicsSearchParams = topicsSearchParams;
        }

        public override ICoursesSearchModel GetModel()
        {
            Model.Instructor.Items = 
                ToSelectList(CoursesSearchBll.GetAllowedInstructors(_instructorsSearchParams), s => s);

            Model.Topic.Items =
                ToSelectList(CoursesSearchBll.GetAllowedTopics(_topicsSearchParams), s => s);

            Model.Start.Items =
                ToSelectList(CoursesSearchBll.GetAllowedStartDatas(_startDateSearchParams),
                    time => time?.ToLongDateString());

            Model.End.Items =
                ToSelectList(CoursesSearchBll.GetAllowedEndDatas(_endDateSearchParams),
                    time => time?.ToLongDateString());

            Model.Level.Items =
                ToSelectList(CoursesSearchBll.GetAllowedLevels(_levelSearchParams), s => s.ToString());


            return Model;
        }


        private List<SelectListItem> ToSelectList<T>(IEnumerable<T> list, Func<T, string> convMethod, string additionalString = "")
        {
            var selectList = new List<SelectListItem>();

            foreach (var item in list)
            {
                selectList.Add(new SelectListItem { Text = convMethod(item) + additionalString, Value = convMethod(item) });
            }

            return selectList;
        }
    }
}