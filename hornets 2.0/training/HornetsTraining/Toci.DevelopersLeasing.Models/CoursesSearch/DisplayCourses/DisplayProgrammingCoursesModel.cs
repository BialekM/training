using System.Collections.Generic;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;

namespace Toci.DevelopersLeasing.Models.CoursesSearch.DisplayCourses
{
    public class DisplayProgrammingCoursesModel : IDisplayCoursesModel
    {
        public DisplayProgrammingCoursesModel(List<ICourseDisplay> courses)
        {
            Courses = courses;
        }

        public List<ICourseDisplay> Courses { get; set; }
    }
}