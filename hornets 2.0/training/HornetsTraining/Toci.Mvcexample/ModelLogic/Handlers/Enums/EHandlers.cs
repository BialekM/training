using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Mvcexample.ModelLogic.Handlers.Enums
{
    [Flags]
    public enum EHandlers
    {
        CoursesSearch = 1,
        OurInstructors = 2,
        RecentProjects = 4
    }
}