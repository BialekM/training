namespace Toci.EmployeeLeasing.HandlerStrategies.Interfaces
{
    public interface IHandlerStrategy<TModel>
    {
        TModel GetModel();
    }
}