using System;
using System.Linq;

namespace Toci.Mvcexample.Ntier.Bll.Interfaces
{
    public interface ICoursesSearchLogic : ILogic
    {
        IQueryable<string> GetAllowedTopics(DateTime? start = null, DateTime? end = null,
            int? level = null, string instructor = null);
        IQueryable<DateTime?> GetAllowedStartDatas(string topic = null, DateTime? end = null,
            int? level = null, string instructor = null);
        IQueryable<DateTime?> GetAllowedEndDatas(string topic = null, DateTime? start = null,
            int? level = null, string instructor = null);
        IQueryable<int?> GetAllowedLevels(string topic = null, DateTime? start = null, DateTime? end = null,
            string instructor = null);
        IQueryable<string> GetAllowedInstructors(string topic = null, DateTime? start = null, DateTime? end = null,
            int? level = null);
    }
}