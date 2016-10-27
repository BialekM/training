using System;
using System.Linq;
using Toci.Mvcexample.Ntier.Bll.Interfaces;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Bll.CoursesSearch
{
    public class CoursesSearchLogic : Logic, ICoursesSearchLogic
    {
        private readonly ICoursesSearchDal _coursesSearchDal;

        public CoursesSearchLogic(ICoursesSearchDal coursesSearchDal)
        {
            _coursesSearchDal = coursesSearchDal;
        }

        public IQueryable<string> GetAllowedTopics(DateTime? start = null, DateTime? end = null,
            int? level = null, string instructor = null)
        {
            return _coursesSearchDal.GetCourses(null, start, end, level, instructor).Select(courses => courses.topic);
        }

        public IQueryable<DateTime?> GetAllowedStartDatas(string topic = null, DateTime? end = null,
            int? level = null, string instructor = null)
        {
            return _coursesSearchDal.GetCourses(topic, null, end, level, instructor).Select(courses => courses.start_date);
        }

        public IQueryable<DateTime?> GetAllowedEndDatas(string topic = null, DateTime? start = null,
            int? level = null, string instructor = null)
        {
            return _coursesSearchDal.GetCourses(topic, start, null, level, instructor).Select(courses => courses.end_date);
        }

        public IQueryable<int?> GetAllowedLevels(string topic = null, DateTime? start = null, DateTime? end = null,
            string instructor = null)
        {
            return _coursesSearchDal.GetCourses(topic, start, end, null, instructor).Select(courses => courses.level);
        }

        public IQueryable<string> GetAllowedInstructors(string topic = null, DateTime? start = null, DateTime? end = null,
            int? level = null)
        {
            return _coursesSearchDal.GetCourses(topic, start, end, level, null).Select(courses => 
                courses.technologypromotor.account.firstName + courses.technologypromotor.account.lastName);
        }
    }
}