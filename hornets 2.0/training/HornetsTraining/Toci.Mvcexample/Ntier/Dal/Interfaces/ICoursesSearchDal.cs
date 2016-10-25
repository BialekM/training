using System;
using System.Linq;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;
using Toci.Mvcexample.Models.DBContext;

namespace Toci.Mvcexample.Ntier.Dal.Interfaces
{
    public interface ICoursesSearchDal
    {
        IQueryable<string> GetTopics();
        IQueryable<DateTime?> GetStartDatas();
        IQueryable<DateTime?> GetEndDatas();
        IQueryable<int?> GetLevels();
        IQueryable<string> GetInstructors();

        IQueryable<course> GetCourses(string topic = null, DateTime? start = null, DateTime? end = null,
            int? level = null, string instructor = null);
    }
}