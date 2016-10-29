using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.Models.NewCoursesSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.CoursesSearch;
using Toci.Mvcexample.Ntier.Bll.Interfaces;

namespace Toci.Mvcexample.ModelLogic.Strategy.CoursesSearch
{
    public abstract class CoursesSearchModelStrategy : ICoursesSearchModelStrategy
    {
        protected CoursesSearchLogic Logic;


        public abstract CoursesSearchModel GetModel(ILogic logic);
    }
}