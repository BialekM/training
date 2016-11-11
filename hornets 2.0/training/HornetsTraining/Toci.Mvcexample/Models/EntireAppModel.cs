using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.Instructors;
using Toci.EmployeeLeasing.Models.Interfaces.RecentProjects;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Models.RecentCourses;

namespace Toci.Mvcexample.Models
{
    public class EntireAppModel : HandlerRefType
    {
        public IInstructorsModel Instructors { get; set; }

        public ICoursesSearchModel CoursesSearch { get; set; }

        public IRecentProjectsModel RecentProjects { get; set; }
    }
}