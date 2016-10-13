using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;

namespace Toci.Mvcexample.ModelLogic
{
    public class ModelLogic : ModelLogicBase
    {
        public ModelLogic(Dictionary<string, Handler> handlers)
        {
            Handlers = new EntirreAppModelChor(handlers);

        }
    }
}