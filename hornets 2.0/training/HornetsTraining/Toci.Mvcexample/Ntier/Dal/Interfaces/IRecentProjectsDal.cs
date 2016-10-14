using Toci.Mvcexample.Models.RecentCourses;

namespace Toci.Mvcexample.Ntier.Dal.Interfaces
{
    public interface IRecentProjectsDal
    {
         RecentProjectsModel GetRecentProjects(RecentProjectsModel model);
    }
}