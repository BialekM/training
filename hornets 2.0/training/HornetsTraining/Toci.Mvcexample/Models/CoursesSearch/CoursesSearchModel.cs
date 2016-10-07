using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//Niepotrzebne, zbyt duze rozdrabnianie modeli ?

namespace Toci.Mvcexample.Models.CoursesSearch
{
    public class CoursesSearchModel
    {
        public DropDownListModel<string> Discipline { get; set; }

        public DropDownListModel<int?> Duration { get; set; }

        public DropDownListModel<string> CourseLevel { get; set; }

        public DropDownListModel<string> Location { get; set; }


        public static List<SelectListItem> ToSelectList(IEnumerable<string> list, string additionalString = "")
        {
            var selectList = new List<SelectListItem>();

            foreach (var item in list)
            {
                selectList.Add(new SelectListItem { Text = item + additionalString, Value = item });
            }

            return selectList;
        }

        public CoursesSearchModel()
        {
            Discipline = new DropDownListModel<string>();
            Duration = new DropDownListModel<int?>();
            CourseLevel = new DropDownListModel<string>();
            Location = new DropDownListModel<string>();
        }

    }
}