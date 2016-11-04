using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Toci.Mvcexample.Models.DevelopersSearch;
using Toci.Mvcexample.Ntier.Bll;
using Toci.Mvcexample.Ntier.Bll.DevelopersSearch;
using Toci.Mvcexample.Ntier.Bll.Interfaces;

namespace Toci.Mvcexample.ModelLogic.Strategy.DevelopersSearch
{
    public class DevelopersSearchModelStrateg : IDevelopersSearchStartegy
    {
        protected DevelopersSearchLogic Logic;


        public DevelopersSearchModel GetModel()
        {

            throw new NotImplementedException();
        }

        public void SearchDevelopers(string technology, double duration, double price, double devsExperience, int devsNumber = 0)
        {
            //throw new NotImplementedException();
        }
    }
}