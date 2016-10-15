using Toci.DesignPatterns.ExceptionHandling;
using Toci.Mvcexample.Models.RecentCourses;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Dal.RecentProjects
{
    public class RecentProjectsDal : DataAccessLayer, IRecentProjectsDal
    {
        public RecentProjectsModel GetRecentProjects(RecentProjectsModel model)
        {
            throw new TociDbApplicationException("_resources",2,"message");
        }
    }
}