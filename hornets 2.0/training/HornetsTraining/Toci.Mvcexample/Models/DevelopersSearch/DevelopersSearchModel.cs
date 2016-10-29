using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Mvcexample.Models.DevelopersSearch
{
    public class DevelopersSearchModel
    {
        public SearchValues ClientRequest { get; set; }
        public List<DeveloperModel> Developers { get; set; }
    }
}