using System.Collections.Generic;

namespace Toci.DesignPatterns.ChainOfResponsibility
{
    public abstract class Chor
    {
        protected Dictionary<string, Handler>  Handlers { get; set; }

        protected Chor(Dictionary<string, Handler> handlers)
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