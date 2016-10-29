using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Mvcexample.Models.DevelopersSearch
{
    public class DeveloperModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Technologies { get; set; }
        public double PerHourCost { get; set; }
        public string Experience { get; set; }

    }
}