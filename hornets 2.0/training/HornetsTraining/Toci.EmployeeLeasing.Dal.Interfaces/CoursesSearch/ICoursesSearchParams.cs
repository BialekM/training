using System;
using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch
{
    public interface ICoursesSearchParams
    {
        IEnumerable<string> Technologies { get; set; }
        string Topic { get; set; }
        string Instructor { get; set; }
        int? Level { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }

    }
}