using System;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll.CoursesSearch
{
    public class ProgrammingCoursesStartDateSearchParams : IStartDateSearchParams
    {
        public string Topic { get; set; }
        public string Instructor { get; set; }
        public int? Level { get; set; }
        public DateTime? End { get; set; }
    }
}