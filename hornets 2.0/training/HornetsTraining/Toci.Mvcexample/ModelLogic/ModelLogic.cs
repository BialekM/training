using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;

namespace Toci.Mvcexample.ModelLogic
{
    public class ModelLogic : ModelLogicBase
    {
        public ModelLogic()
        {
            Handlers = new EntirreAppModelChor(new Dictionary<string, Handler>
            {
                { "instructors", new InstructorsHandler() },
                { "coursesSearch", new CoursesSearchHandler() },
            });
        }
    }
}