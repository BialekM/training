using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.Mvcexample.Models.NewCoursesSearch.CourseDisplay;

namespace Toci.Mvcexample.Models.NewCoursesSearch
{
    public class CoursesSearchModel
    {
        public CoursesDisplayModel Courses { get; set; }


        public DropDownListModel<string> Topic { get; set; }

        public DropDownListModel<DateTime?> Start { get; set; }

        public DropDownListModel<DateTime?> End { get; set; }

        public DropDownListModel<string> Level { get; set; }

        public DropDownListModel<string> Instructor { get; set; }
    }
}