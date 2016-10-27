using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models.DBContext;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;

namespace Toci.MvcTests.DatabaseAccess
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DatabaseAccessTest()
        {
            var dbContext = new TeamLeasingDBContext();

            var coursesLevels = dbContext.course.Select(course => course.level).ToList();

            var basicStrategy = new CoursesSearchModelStrategyBasic();

            CoursesSearchModel model = basicStrategy.GetModel(new CoursesSearchLogic(new CoursesSearchDal()));

        }
    }
}
