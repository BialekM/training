using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.DesignPatterns.ChainOfResponsibility.Interfaces;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class EntirreAppModelChor : Chor
    {
        public EntirreAppModelChor(Dictionary<string, IModelHandler> handlers) : base(handlers)
        {
        }
    }
}