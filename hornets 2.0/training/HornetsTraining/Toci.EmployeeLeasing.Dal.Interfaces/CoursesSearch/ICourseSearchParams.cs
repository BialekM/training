using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch
{
    public interface ICourseSearchParams
    {
        IEnumerable<string> Technology { get; set; }
    }
}