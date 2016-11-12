namespace Toci.DesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IModelHandler
    {
        void Handle(HandlerRefType entity);
    }
}