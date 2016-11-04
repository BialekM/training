using System;
using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch
{
    public interface ITopicsSearchParams
    {
        string Instructor { get; set; }
        int? Level { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}