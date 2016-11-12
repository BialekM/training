using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses
{
    public interface IDisplayCoursesModel
    {
        List<ICourseDisplay> Courses { get; set; }
    }
}