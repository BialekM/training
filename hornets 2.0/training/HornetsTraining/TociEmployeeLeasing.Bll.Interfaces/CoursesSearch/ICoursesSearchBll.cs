using System;
using System.Linq;
using Toci.EmployeeLeasing.Dal.Interfaces.CoursesSearch;

namespace Toci.EmployeeLeasing.Bll.Interfaces.CoursesSearch
{
    public interface ICoursesSearchBll
    {
        IQueryable<string> GetAllowedTopics(ITopicsSearchParams searchParams);
        IQueryable<DateTime?> GetAllowedStartDatas(IStartDateSearchParams searchParams);
        IQueryable<DateTime?> GetAllowedEndDatas(IEndDateSearchParams searchParams);
        IQueryable<int?> GetAllowedLevels(ILevelSearchParams searchParams);
        IQueryable<string> GetAllowedInstructors(IInstructorsSearchParams searchParams);
    }
}