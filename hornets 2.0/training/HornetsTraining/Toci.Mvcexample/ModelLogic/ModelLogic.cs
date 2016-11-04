using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Handlers;
using Toci.Mvcexample.ModelLogic.Handlers.Enums;

namespace Toci.Mvcexample.ModelLogic
{
    public class ModelLogic : ModelLogicBase
    {
        public ModelLogic(EHandlers handlers)
        {
            Handlers = new EntirreAppModelChor(new EnumsConvert().ToHandlers(handlers));
        }

        public ModelLogic(Dictionary<string, Handler> handlers)
        {
            Handlers = new EntirreAppModelChor(handlers);
        }
    }
}