using System;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll.CoursesSearch
{
    public class ProgrammingCoursesLevelsSearchParams : ILevelSearchParams
    {
        public string Topic { get; set; }
        public string Instructor { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}