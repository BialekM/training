using System;
using System.Collections.Generic;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training1.HomeWork;
using Toci.HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Toci.HornetsTraining.Training1.HomeWork.Haski;
using Toci.HornetsTraining.Training1.HomeWork.KrzysztofPater;
using Toci.HornetsTraining.Training1.HomeWork.LukaszSmierzchala;

namespace Toci.HornetsTraining.Training1.Generics.Factory
{
    public class DelegateStringOperationsFactory :  DelegateFactoryBase<IStringOperations>
    {
        public DelegateStringOperationsFactory()
        {
            ListOfInstances = new Dictionary<string, Func<IStringOperations>>
            {
                { "Adrian", delegate { return new AdrianPankiewiczStringOperations(); } },
                { "Lukasz", delegate { return new LukaszSmierzchalaStringOperations(); } },
                { "Krzysztof", delegate { return new KrzysztofPaterStringOperations(); } },
                { "Haski", () => new HaskiStringOperations() },
            };
        }
    }
}