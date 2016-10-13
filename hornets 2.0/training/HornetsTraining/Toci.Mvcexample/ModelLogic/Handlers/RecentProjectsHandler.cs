using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.RecentCourses;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class RecentProjectsHandler : Handler
    {
        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            var projects = new List<Project>()
            {
                new Project()
                {
                    NameProject = "System for bank",
                    Developers = new List<string> {"Bartek", "Piotr", "Łukasz", "Michał"},
                    EndDate = "10.09.2016",
                    StartDate = "22.04.2015",
                    Technologies = new List<string>{"c#","html", "css"},
                    UrlWebsite = "https://www.mbank.pl/"
                },
                new Project()
                {
                    NameProject = "Team leasingi",
                    Developers = new List<string> {"Bartek","Tomasz"},
                    EndDate = "10.03.2016",
                    StartDate = "22.04.2014",
                    Technologies = new List<string>{"java","html", "css"},
                    UrlWebsite = "#"
                }
            };
            model.RecentProjects = new  RecentProjectsModel();
            model.RecentProjects.Projects = projects;
        }
    }
}