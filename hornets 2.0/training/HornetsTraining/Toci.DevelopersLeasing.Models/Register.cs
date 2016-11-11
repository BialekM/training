using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.DevelopersLeasing.Models.CoursesSearch;
using Toci.DevelopersLeasing.Models.CoursesSearch.DisplayCourses;
using Toci.DevelopersLeasing.Models.Instructors;
using Toci.DevelopersLeasing.Models.RecentProjects;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;
using Toci.EmployeeLeasing.Models.Interfaces.Instructors;
using Toci.EmployeeLeasing.Models.Interfaces.RecentProjects;

namespace Toci.DevelopersLeasing.Models
{
    public static class Register
    {
        public static Dictionary<Type, Type> GetTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(IDisplayCoursesModel), typeof(DisplayProgrammingCoursesModel) },
                {typeof(ICourseDisplay), typeof(ProgrammingCourseDisplay) },
                {typeof(IInstructorsModel), typeof(InstructorsModel) },
                {typeof(ICoursesSearchModel), typeof(ProgrammingCoursesSearchModel) },
                {typeof(IInstructor), typeof(Instructor) },
                {typeof(IProjectModel), typeof(ProjectModel) },
                {typeof(IRecentProjectsModel), typeof(RecentProjectsModel) }
            };
        }

        public static Dictionary<Type, Type> GetGenericTypesToRegister()
        {
            return new Dictionary<Type, Type>
            {
                {typeof(IDropDownListModel<>), typeof(DropDownListModel<>) }
            };
        }
    }
}
