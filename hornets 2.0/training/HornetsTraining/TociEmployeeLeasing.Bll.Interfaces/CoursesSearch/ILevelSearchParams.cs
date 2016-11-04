using System;
using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch
{
    public interface ILevelSearchParams
    {
        string Topic { get; set; }
        string Instructor { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
    }
}