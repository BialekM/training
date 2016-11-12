using System.Collections.Generic;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;

namespace Toci.DevelopersLeasing.Models.CoursesSearch.DisplayCourses
{
    public class ProgrammingCourseDisplay : ICourseDisplay
    {
        public string Name { get; set; }
        public List<string> Keywords { get; set; }
    }
}