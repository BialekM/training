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
        private ICoursesSearchLogic _logic;

        public CoursesSearchHandler(ICoursesSearchModelStrategy strategy, ICoursesSearchLogic logic)
        {
            _strategy = strategy;
            _logic = logic;
        }

        public override void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            model.CoursesSearch = _strategy.GetModel(_logic);  //-> w ostatecznej wersji w ten sposob ?
        }
    }
}