using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Models.DBContext;

namespace HornetsTesting.MVCTests.PluginDiTests
{
    [TestClass]
    public class DITests
    {
        [TestMethod]
        public void TestDI()
        {
            var db = new TeamLeasingDBContext();

            var x = db.course.Select(m => m.agenda).ToList();
            //var exampleInstance = ExampleAutofacResolve.ResolveType<ExampleClass2>();
            //exampleInstance.InvokeIt();

            var bllTest = ExampleAutofacResolve.ResolveType<TestBllImplementation>();
            var instructors = bllTest.GetInstructors();

            var startDates = bllTest.GetStartDates();

            CoursesSearchModel model = new CoursesSearchModel();
            
        }
    }
}
