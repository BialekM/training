using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.EmployeeLeasing.HandlerStrategies.Interfaces.CoursesSearch;
using Toci.EmployeeLeasing.ModelHandlers.Interfaces.CoursesSearch;
using Toci.Mvcexample.Models;

namespace Toci.DevelopersLeasing.ModelHandlers.CoursesSearch
{
    public class ProgrammingCoursesSearchHandler : ICoursesSearchHandler
    {
        private ICoursesSearchHandlerStrategy _strategy;

        public ProgrammingCoursesSearchHandler(ICoursesSearchHandlerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Handle(HandlerRefType entity)
        {
            EntireAppModel model = (EntireAppModel)entity;

            //model.CoursesSearch = _strategy.GetModel();
        }
    }
}