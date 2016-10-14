using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public class CoursesSearchModelStrategyBasic : CoursesSearchModelStrategy
    {
        public override CoursesSearchModel GetModel(Logic logic)
        {
            Logic = (CoursesSearchLogic) logic;

            var model = new CoursesSearchModel();

            return model;
        }
    }
}