using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.DevelopersLeasing.Models.RecentProjects;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.RecentProjects;
using Toci.EmployeeLeasing.Models.Interfaces.RecentProjects;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.RecentCourses;

namespace Toci.DevelopersLeasing.ModelHandlers.RecentProjects
{
    public class ProgrammingRecentProjectsHandler : IRecentProjectsHandler
    {
        private IRecentProjectsModel _recentProjectsModel;

        public ProgrammingRecentProjectsHandler(IRecentProjectsModel model)
        {
            _recentProjectsModel = model;
        }

        public void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            _recentProjectsModel.Projects.Add(new ProjectModel
            {
                NameProject = "System for bank",
                Developers = new List<string> { "Bartek", "Piotr", "Łukasz", "Michał" },
                EndDate = "10.09.2016",
                StartDate = "22.04.2015",
                Technologies = new List<string> { "c#", "html", "css" },
                UrlWebsite = "https://www.mbank.pl/"
            });

            _recentProjectsModel.Projects.Add(new ProjectModel
            {
                NameProject = "Team leasingi",
                Developers = new List<string> {"Bartek", "Tomasz"},
                EndDate = "10.03.2016",
                StartDate = "22.04.2014",
                Technologies = new List<string> {"java", "html", "css"},
                UrlWebsite = "#"
            });

            model.RecentProjects = _recentProjectsModel;
        }
    }
}