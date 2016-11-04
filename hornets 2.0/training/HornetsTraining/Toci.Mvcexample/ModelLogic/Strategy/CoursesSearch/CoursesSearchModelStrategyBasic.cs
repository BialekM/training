using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll.Interfaces;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public class CoursesSearchModelStrategyBasic : CoursesSearchModelStrategy
    {
        private IEndDateSearchParams _endDateSearchParams;
        private IInstructorsSearchParams _instructorsSearchParams;
        private ILevelSearchParams _levelSearchParams;
        private IStartDateSearchParams _startDateSearchParams;
        private ITopicsSearchParams _topicsSearchParams;

        private CoursesSearchModel _recentModel;

        public CoursesSearchModelStrategyBasic(
            ICoursesSearchBll coursesSearchBll,
            IEndDateSearchParams endDateSearchParams,
            IInstructorsSearchParams instructorsSearchParams,
            ILevelSearchParams levelSearchParams,
            IStartDateSearchParams startDateSearchParams,
            ITopicsSearchParams topicsSearchParams,
            CoursesSearchModel recentModel) 
            : base(coursesSearchBll)
        {
            _endDateSearchParams = endDateSearchParams;
            _instructorsSearchParams = instructorsSearchParams;
            _levelSearchParams = levelSearchParams;
            _startDateSearchParams = startDateSearchParams;
            _topicsSearchParams = topicsSearchParams;
            _recentModel = recentModel;
        }

        public override CoursesSearchModel GetModel()
        {
            var model = new CoursesSearchModel
            {
                Instructor = new DropDownListModel<string>
                {
                    Items = ToSelectList(CoursesSearchBll.GetAllowedInstructors(_instructorsSearchParams), s => s)
                },
                Topic = new DropDownListModel<string>
                {
                    Items = ToSelectList(CoursesSearchBll.GetAllowedTopics(_topicsSearchParams), s => s)
                },
                End = new DropDownListModel<DateTime?>
                {
                    Items = ToSelectList(CoursesSearchBll.GetAllowedEndDatas(_endDateSearchParams), 
                        time => time?.ToLongDateString())
                },
                Start = new DropDownListModel<DateTime?>
                {
                    Items = ToSelectList(CoursesSearchBll.GetAllowedStartDatas(_startDateSearchParams),
                        time => time?.ToLongDateString())
                },
                Level = new DropDownListModel<string>
                {
                    Items = ToSelectList(CoursesSearchBll.GetAllowedLevels(_levelSearchParams), s => s.ToString())
                }
                
            };


            return model;
        }

        private List<SelectListItem> ToSelectList<T>(IEnumerable<T> list, Func<T, string> convMethod, string additionalString = "")
        {
            var selectList = new List<SelectListItem>();

            foreach (var item in list)
            {
                selectList.Add(new SelectListItem {Text = convMethod(item) + additionalString, Value = convMethod(item) });
            }

            return selectList;
        }
    }
}
