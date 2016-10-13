using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public abstract class CoursesSearchModelStrategy : ICoursesSearchModelStrategy
    {
        protected CoursesSearchLogic Logic;
        public abstract CoursesSearchModel GetModel(Logic logic);
    }
}