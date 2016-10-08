namespace Toci.DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        public abstract void Handle(HandlerRefType entity);
    }
}