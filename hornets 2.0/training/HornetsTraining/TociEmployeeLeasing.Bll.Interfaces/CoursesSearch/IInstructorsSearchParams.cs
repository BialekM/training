using System;
using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch
{
    public interface IInstructorsSearchParams
    {
        string Topic { get; set; }
        int? Level { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}