using Toci.DesignPatterns.ChainOfResponsibility;
using Toci.Mvcexample.ModelLogic.Interfaces;
using Toci.Mvcexample.Models;

namespace Toci.Mvcexample.ModelLogic
{
    public abstract class ModelLogicBase : IModelLogic
    {
        protected Chor Handlers { get; set; }

        public virtual EntireAppModel GetEntireAppModel()
        {
            EntireAppModel model = new EntireAppModel();

            Handlers.Handle(model);

            return model;
        }
    }
}