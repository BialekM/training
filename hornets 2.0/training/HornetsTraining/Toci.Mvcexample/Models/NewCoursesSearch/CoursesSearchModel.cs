using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Mvcexample.Models.NewCoursesSearch
{
    public class CoursesSearchModel
    {
        public DropDownListModel<string> Topic { get; set; }

        public DropDownListModel<DateTime?> Start { get; set; }

        public DropDownListModel<DateTime?> End { get; set; }

        public DropDownListModel<string> Level { get; set; }

        public DropDownListModel<string> Instructor { get; set; }
    }
}