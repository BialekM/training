using System;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;

namespace Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch
{
    public interface ICoursesSearchModel
    {
        IDisplayCoursesModel Courses { get; set; }


        IDropDownListModel<string> Topic { get; set; }

        IDropDownListModel<DateTime?> Start { get; set; }

        IDropDownListModel<DateTime?> End { get; set; }

        IDropDownListModel<string> Level { get; set; }

        IDropDownListModel<string> Instructor { get; set; }
    }
}