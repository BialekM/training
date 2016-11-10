using Toci.DesignPatterns.ChainOfResponsibility;

namespace Toci.EmployeeLeasing.ModelHandlers.Interfaces
{
    public interface IModelHandler
    {
        void Handle(HandlerRefType entity);
    }
}