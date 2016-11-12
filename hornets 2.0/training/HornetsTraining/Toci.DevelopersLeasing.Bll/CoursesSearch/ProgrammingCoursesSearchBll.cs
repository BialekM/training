using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.DevelopersLeasing.Bll.CoursesSearch
{
    public class ProgrammingCoursesSearchBll : ICoursesSearchBll
    {
        private ICoursesSearchDal _coursesSearchDal;
        private ICoursesSearchParams _coursesSearchParams;

        public ProgrammingCoursesSearchBll(ICoursesSearchDal coursesSearchDal, ICoursesSearchParams coursesSearchParams)
        {
            _coursesSearchDal = coursesSearchDal;
            _coursesSearchParams = coursesSearchParams;
        }

        public IQueryable<string> GetAllowedTopics(ITopicsSearchParams searchParams)
        {
            _coursesSearchParams.Start = searchParams.Start;
            _coursesSearchParams.End = searchParams.End;
            _coursesSearchParams.Instructor = searchParams.Instructor;
            _coursesSearchParams.Level = searchParams.Level;
            _coursesSearchParams.Topic = null;
            _coursesSearchParams.Technologies = null;

            return _coursesSearchDal.GetCourses(_coursesSearchParams).Select(courseModel => courseModel.CourseName).Distinct();
        }

        public IQueryable<DateTime?> GetAllowedStartDatas(IStartDateSearchParams searchParams)
        {
            _coursesSearchParams.Start = null;
            _coursesSearchParams.End = searchParams.End;
            _coursesSearchParams.Instructor = searchParams.Instructor;
            _coursesSearchParams.Level = searchParams.Level;
            _coursesSearchParams.Topic = searchParams.Topic;
            _coursesSearchParams.Technologies = null;

            return _coursesSearchDal.GetCourses(_coursesSearchParams).Select(courseModel => courseModel.Start).Distinct();
        }

        public IQueryable<DateTime?> GetAllowedEndDatas(IEndDateSearchParams searchParams)
        {
            _coursesSearchParams.Start = searchParams.Start;
            _coursesSearchParams.End = null;
            _coursesSearchParams.Instructor = searchParams.Instructor;
            _coursesSearchParams.Level = searchParams.Level;
            _coursesSearchParams.Topic = searchParams.Topic;
            _coursesSearchParams.Technologies = null;

            return _coursesSearchDal.GetCourses(_coursesSearchParams).Select(courseModel => courseModel.End).Distinct();
        }

        public IQueryable<int?> GetAllowedLevels(ILevelSearchParams searchParams)
        {
            _coursesSearchParams.Start = searchParams.Start;
            _coursesSearchParams.End = searchParams.End;
            _coursesSearchParams.Instructor = searchParams.Instructor;
            _coursesSearchParams.Level = null;
            _coursesSearchParams.Topic = searchParams.Topic;
            _coursesSearchParams.Technologies = null;

            return _coursesSearchDal.GetCourses(_coursesSearchParams).Select(courseModel => courseModel.Level).Distinct();
        }

        public IQueryable<string> GetAllowedInstructors(IInstructorsSearchParams searchParams)
        {
            _coursesSearchParams.Start = searchParams.Start;
            _coursesSearchParams.End = searchParams.End;
            _coursesSearchParams.Instructor = null;
            _coursesSearchParams.Level = searchParams.Level;
            _coursesSearchParams.Topic = searchParams.Topic;
            _coursesSearchParams.Technologies = null;

            return _coursesSearchDal.GetCourses(_coursesSearchParams).Select(courseModel => courseModel.Instructor).Distinct();
        }

    }
}
