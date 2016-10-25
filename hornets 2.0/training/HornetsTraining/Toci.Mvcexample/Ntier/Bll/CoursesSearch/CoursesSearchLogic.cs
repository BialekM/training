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

        public IQueryable<DateTime?> GetAllowedStartDatas()
        {
            return _coursesSearchDal.GetStartDatas().Distinct();
        }

        public IQueryable<DateTime?> GetAllowedEndDatas()
        {
            return _coursesSearchDal.GetEndDatas().Distinct();
        }

        public IQueryable<int?> GetAllowedLevels()
        {
            return _coursesSearchDal.GetLevels().Distinct();
        }

        public IQueryable<string> GetAllowedInstructors()
        {
            return _coursesSearchDal.GetInstructors().Distinct();
        }
    }
}