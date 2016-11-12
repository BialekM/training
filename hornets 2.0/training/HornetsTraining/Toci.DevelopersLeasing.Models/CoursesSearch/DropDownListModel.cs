using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Models.CoursesSearch
{
    public class DropDownListModel<T> : IDropDownListModel<T>
    {
        public List<SelectListItem> Items { get; set; }
        public T Value { get; set; }
    }
}
