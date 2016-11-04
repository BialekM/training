using System;
using System.Collections.Generic;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Dal.CoursesSearch
{
    public class ProgrammingCoursesSearchParams : ICoursesSearchParams
    {
        public IEnumerable<string> Technologies { get; set; }
        public string Topic { get; set; }
        public string Instructor { get; set; }
        public int? Level { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}