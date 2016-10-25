using System;
using System.Linq;

namespace Toci.Mvcexample.Ntier.Bll.Interfaces
{
    public interface ICoursesSearchLogic
    {
        IQueryable<string> GetAllowedTopics(DateTime? start = null, DateTime? end = null,
            int? level = null, string instructor = null);
        IQueryable<DateTime?> GetAllowedStartDatas();
        IQueryable<DateTime?> GetAllowedEndDatas();
        IQueryable<int?> GetAllowedLevels();
        IQueryable<string> GetAllowedInstructors();
    }
}