using System.Collections.Generic;
using System.Web.Mvc;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.Models;
using Toci.Mvcexample.Models.CoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class CoursesSearchHandler : Handler
    {
        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            model.CoursesSearch = new CoursesSearchModel
            {
                CourseLevel = new DropDownListModel<string> { Items = new List<SelectListItem> { new SelectListItem { Text = "beginner", Value = "beginner"} } },
                Discipline = new DropDownListModel<string> { Items = new List<SelectListItem>
                {
                    new SelectListItem { Text = "c#", Value = "c#" },
                    new SelectListItem { Text = "php", Value = "php" }
                } },
                Duration = new DropDownListModel<int?> { Items = new List<SelectListItem> { new SelectListItem { Text = "3", Value = "3" } } },
                Location = new DropDownListModel<string> { Items = new List<SelectListItem> { new SelectListItem { Text = "internet", Value = "internet" } } }
            };
        }
    }
}