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

        public CoursesSearchHandler(ICoursesSearchModelStrategy strategy)
        {
            _strategy = strategy;
        }

        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            model.CoursesSearch = _strategy.GetModel();  //-> w ostatecznej wersji w ten sposob ?
        }
    }
}