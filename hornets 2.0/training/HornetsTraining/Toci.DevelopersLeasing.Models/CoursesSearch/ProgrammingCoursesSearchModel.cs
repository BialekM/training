using System;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Models.Interfaces.CoursesSearch.DisplayCourses;

namespace Toci.DevelopersLeasing.Models.CoursesSearch
{
    public class ProgrammingCoursesSearchModel : ICoursesSearchModel
    {
        public ProgrammingCoursesSearchModel(
            IDisplayCoursesModel courses,
            IDropDownListModel<string> topic,
            IDropDownListModel<DateTime?> start,
            IDropDownListModel<DateTime?> end,
            IDropDownListModel<string> level,
            IDropDownListModel<string> instructor)
        {
            //Courses = courses;
            Topic = topic;
            Start = start;
            End = end;
            Level = level;
            Instructor = instructor;
        }

        public IDisplayCoursesModel Courses { get; set; }

        public IDropDownListModel<string> Topic { get; set; }
        public IDropDownListModel<DateTime?> Start { get; set; }
        public IDropDownListModel<DateTime?> End { get; set; }
        public IDropDownListModel<string> Level { get; set; }
        public IDropDownListModel<string> Instructor { get; set; }
    }
}