using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Mvcexample.Ntier.Bll;

namespace Toci.Mvcexample.ModelLogic.Strategy
{
    public interface IModelStrategy<TModel>
    {
        TModel GetModel(Logic logic);
    }
}
