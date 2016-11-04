using System;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll.CoursesSearch
{
    public class ProgrammingCoursesTopicsSearchParams : ITopicsSearchParams
    {
        public string Instructor { get; set; }
        public int? Level { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}