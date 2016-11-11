using System.Collections.Generic;
using Toci.DesignPatterns.ChainOfResponsibility.Interfaces;

namespace Toci.DesignPatterns.ChainOfResponsibility
{
    public abstract class Chor
    {
        protected Dictionary<string, IModelHandler>  Handlers { get; set; }

        protected Chor(Dictionary<string, IModelHandler> handlers)
        {
            Handlers = handlers;
        }

        public virtual void Handle(HandlerRefType entity)
        {
            foreach (var handler in Handlers)
            {
                handler.Value.Handle(entity);
            }
        }
    }
}