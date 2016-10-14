using Toci.Mvcexample.Ntier.Bll.Interfaces;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Bll.RecentProjects
{
    public class RecentProjectsLogic : Logic, IRecentProjectsLogic
    {
        IRecentProjectsDal RecentProjectsDal;

        public RecentProjectsLogic(IRecentProjectsDal recentProjectsDal)
        {
            
        }

    }
}