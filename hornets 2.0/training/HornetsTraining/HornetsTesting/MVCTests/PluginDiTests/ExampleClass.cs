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
        private ICoursesSearchDal _coursesSearch;

        public ExampleClass(ICoursesSearchDal coursesSearch)
        {
            _coursesSearch = coursesSearch;
        }

        public void InvokeIt()
        {
            _coursesSearch.GetCourses(null);
        }
    }

    public class ExampleClass2
    {
        private ICoursesSearchDal _model;

        public ExampleClass2(ICoursesSearchDal model)
        {
            _model = model;
        }

    }
}
