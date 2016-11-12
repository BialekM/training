using System.Collections.Generic;
using System.Linq;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;

namespace Toci.DevelopersLeasing.Models.CoursesSearch.DisplayCourses
{
    public class DisplayProgrammingCoursesModel : IDisplayCoursesModel
    {
        public DisplayProgrammingCoursesModel(IEnumerable<ICourseDisplay> courses)
        {
            Courses = courses.ToList();
        }

        public List<ICourseDisplay> Courses { get; set; }
    }
}