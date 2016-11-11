using System.Collections.Generic;
using System.Linq;
using Toci.EmployeeLeasing.Models.Interfaces.RecentProjects;

namespace Toci.DevelopersLeasing.Models.RecentProjects
{
    public class RecentProjectsModel : IRecentProjectsModel
    {
        public RecentProjectsModel(IEnumerable<IProjectModel> projects)
        {
            Projects = projects.ToList();
            Projects.Clear();
        }

        public List<IProjectModel> Projects { get; set; }
    }
}