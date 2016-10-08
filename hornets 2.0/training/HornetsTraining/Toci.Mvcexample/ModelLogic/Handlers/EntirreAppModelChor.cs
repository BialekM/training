using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility;

namespace Toci.Mvcexample.ModelLogic.Handlers
{
    public class EntirreAppModelChor : Chor
    {
        public EntirreAppModelChor(Dictionary<string, Handler> handlers) : base(handlers)
        {
        }
    }
}