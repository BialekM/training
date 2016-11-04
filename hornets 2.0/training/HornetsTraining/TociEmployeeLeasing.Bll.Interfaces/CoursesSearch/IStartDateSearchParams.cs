using System;
using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch
{
    public interface IStartDateSearchParams
    {
        string Topic { get; set; }
        string Instructor { get; set; }
        int? Level { get; set; }
        DateTime? End { get; set; }
    }
}