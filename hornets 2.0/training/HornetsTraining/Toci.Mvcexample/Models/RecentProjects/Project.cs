using System.Collections.Generic;

namespace Toci.Mvcexample.Models.RecentCourses
{
    public class Project
    {
        public string NameProject { get; set; }
        public string UrlWebsite { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public List<string> Developers { get; set; }
        public List<string>Technologies { get; set; }
 

    }
}