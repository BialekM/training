using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace HornetsTesting.MVCTests.PluginDiTests
{
    public class ExampleClass
    {
        private ICoursesSearch _coursesSearch;

        public ExampleClass(ICoursesSearch coursesSearch)
        {
            _coursesSearch = coursesSearch;
        }

        public void InvokeIt()
        {
            _coursesSearch.GetCourses(null);
        }
    }
}
