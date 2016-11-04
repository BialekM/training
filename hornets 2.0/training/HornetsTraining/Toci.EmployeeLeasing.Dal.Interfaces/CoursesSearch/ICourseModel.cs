using System;

namespace Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch
{
    public interface ICourseModel
    {
        string CourseName { get; set; }
        string Instructor { get; set; }
        int? Level { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
        string Agenda { get; set; }
    }
}