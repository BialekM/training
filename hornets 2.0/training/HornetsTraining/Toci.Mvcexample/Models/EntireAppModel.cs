using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.Models.CoursesSearch;
using Toci.Mvcexample.Models.CoursesSearch.CourseDisplay;

namespace Toci.Mvcexample.Models
{
    public class EntireAppModel : HandlerRefType
    {
        public OurInstructorsModel Instructors { get; set; }

        public CoursesSearchModel CoursesSearch { get; set; }

        public CoursesDisplayModel CoursesResult { get; set; }
    }
}