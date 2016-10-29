using System;
using System.Data.Entity;
using System.Linq;
using Toci.DesignPatterns.ExceptionHandling;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;
using Toci.Mvcexample.Models.DBContext;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Dal.CoursesSearch
{
    public class CoursesSearchDal : DataAccessLayer, ICoursesSearchDal
    {


        public IQueryable<course> GetCourses(string topic = null, DateTime? start = null, DateTime? end = null,
            int? level = null, string instructor = null)
        {
            var test =  TeamLeasingDb.course.Select(m => m);
            //TeamLeasingDb.developer.Select(m => m.tec).technologiesdeveloper.)
            return test;
            /*Where(course =>
                topic == null || course.topic == topic &&
                start == null || course.start_date == start &&
                end == null || course.end_date == end &&
                level == null || course.level == level &&
                instructor == null ||
                course.technologypromotor.account.lastName + " " + course.technologypromotor.account.firstName == instructor);*/
        }
        public IQueryable<string> GetTopics()
        {
            return TeamLeasingDb.course.Select((courses) => courses.topic);
        }

        public IQueryable<DateTime?> GetStartDatas()
        {
            return TeamLeasingDb.course.Select((courses) => courses.start_date);
        }

        public IQueryable<DateTime?> GetEndDatas()
        {
            return TeamLeasingDb.course.Select((courses) => courses.end_date);
        }

        public IQueryable<int?> GetLevels()
        {
            return TeamLeasingDb.course.Select((courses) => courses.level);
        }

        public IQueryable<string> GetInstructors()
        {
            return TeamLeasingDb.course.Select((courses) =>
                    courses.technologypromotor.account.lastName + courses.technologypromotor.account.firstName);
        }
    }
}