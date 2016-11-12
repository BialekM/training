using System.Collections.Generic;
using Toci.EmployeeLeasing.Models.Interfaces.RecentProjects;

namespace Toci.DevelopersLeasing.Models.RecentProjects
{
    public class ProjectModel : IProjectModel
    {
        public string NameProject { get; set; }
        public string UrlWebsite { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<string> Developers { get; set; }
        public List<string> Technologies { get; set; }
    }
}