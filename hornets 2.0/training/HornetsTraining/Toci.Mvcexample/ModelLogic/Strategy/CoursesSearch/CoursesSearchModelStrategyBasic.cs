using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public class CoursesSearchModelStrategyBasic : CoursesSearchModelStrategy
    {
        private CoursesSearchModel _recentModel;

        public CoursesSearchModelStrategyBasic(CoursesSearchModel recentModel = null)
        {
            _recentModel = recentModel;
        }

        public override CoursesSearchModel GetModel(Logic logic)
        {
            Logic = (CoursesSearchLogic) logic;

            var model = new CoursesSearchModel
            {
                Instructor = new DropDownListModel<string>
                {
                    Items = ToSelectList(Logic.GetAllowedInstructors(), s => s)
                },
                Topic = new DropDownListModel<string>
                {
                    Items = ToSelectList(Logic.GetAllowedTopics(), s => s)
                },
                End = new DropDownListModel<DateTime?>
                {
                    Items = ToSelectList(Logic.GetAllowedEndDatas(), 
                        time => time?.ToLongDateString())
                },
                Start = new DropDownListModel<DateTime?>
                {
                    Items = ToSelectList(Logic.GetAllowedStartDatas(),
                        time => time?.ToLongDateString())
                },
                Level = new DropDownListModel<string>
                {
                    Items = ToSelectList(Logic.GetAllowedLevels(), s => s.ToString())
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
