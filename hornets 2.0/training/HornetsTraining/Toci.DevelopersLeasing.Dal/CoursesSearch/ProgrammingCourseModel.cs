using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Dal.CoursesSearch
{
    public class ProgrammingCourseModel : ICourseModel
    {
        public string CourseName { get; set; }
        public string Instructor { get; set; }
        public int? Level { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Agenda { get; set; }
    }
}
