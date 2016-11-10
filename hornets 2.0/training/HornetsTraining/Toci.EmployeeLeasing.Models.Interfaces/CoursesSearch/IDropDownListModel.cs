using System.Collections.Generic;
using System.Web.Mvc;

namespace Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch
{
    public interface IDropDownListModel<T>
    {
        List<SelectListItem> Items { get; set; }

        T Value { get; set; }
    }
}