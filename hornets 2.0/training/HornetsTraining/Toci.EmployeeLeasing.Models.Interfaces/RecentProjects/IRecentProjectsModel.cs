using System.Collections.Generic;

namespace Toci.EmployeeLeasing.Models.Interfaces.RecentProjects
{
    public interface IRecentProjectsModel
    {
        List<IProjectModel> Projects { get; set; }
    }
}