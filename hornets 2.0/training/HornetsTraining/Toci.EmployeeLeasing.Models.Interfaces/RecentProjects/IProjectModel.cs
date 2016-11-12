using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Models.Interfaces.RecentProjects
{
    public interface IProjectModel
    {
        string NameProject { get; set; }
        string UrlWebsite { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        List<string> Developers { get; set; }
        List<string> Technologies { get; set; }
    }
}