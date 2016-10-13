using System.Collections.Generic;
using System.Web.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll.Interfaces;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class CoursesSearchHandler : Handler
    {
        private ICoursesSearchModelStrategy _strategy;
        private CoursesSearchLogic _logic;

        public CoursesSearchHandler(ICoursesSearchModelStrategy strategy, CoursesSearchLogic logic)
        {
            _strategy = strategy;
            _logic = logic;
        }

        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            _strategy.GetModel(_logic);
            model.CoursesSearch = new CoursesSearchModel
            {
                CourseLevel = new DropDownListModel<string> { Items = new List<SelectListItem> { new SelectListItem { Text = "beginner", Value = "beginner" } } },
                Discipline = new DropDownListModel<string>
                {
                    Items = new List<SelectListItem>
                {
                    new SelectListItem { Text = "c#", Value = "c#" },
                    new SelectListItem { Text = "php", Value = "php" }
                }
                },
                Duration = new DropDownListModel<int?> { Items = new List<SelectListItem> { new SelectListItem { Text = "3", Value = "3" } } },
                Location = new DropDownListModel<string> { Items = new List<SelectListItem> { new SelectListItem { Text = "internet", Value = "internet" } } }
            };
        }
    }
}