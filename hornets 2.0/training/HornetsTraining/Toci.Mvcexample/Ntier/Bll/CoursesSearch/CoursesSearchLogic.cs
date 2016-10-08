using Toci.Mvcexample.Ntier.Bll.Interfaces;
using Toci.Mvcexample.Ntier.Dal.CoursesSearch;
using Toci.Mvcexample.Ntier.Dal.Interfaces;

namespace Toci.Mvcexample.Ntier.Bll.CoursesSearch
{
    public class CoursesSearchLogic : Logic, ICoursesSearchLogic
    {
        ICoursesSearchDal CoursesSearchDal;

        public CoursesSearchLogic(ICoursesSearchDal coursesSearchDal)
        {
            
        }
    }
}