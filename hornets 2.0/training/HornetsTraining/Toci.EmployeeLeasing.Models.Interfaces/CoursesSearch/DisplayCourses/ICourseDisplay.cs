using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses
{
    public interface ICourseDisplay
    {
        string Name { get; set; }
        List<string> Keywords { get; set; }
    }
}