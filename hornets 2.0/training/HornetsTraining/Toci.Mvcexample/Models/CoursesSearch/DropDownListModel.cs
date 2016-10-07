using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Toci.Mvcexample.Models.CoursesSearch
{
    public class DropDownListModel<T>
    {
        public List<SelectListItem> Items { get; set; }

        public T Value { get; set; }
    }
}