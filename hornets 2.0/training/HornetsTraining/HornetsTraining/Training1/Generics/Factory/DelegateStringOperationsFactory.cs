using System;
using System.Collections.Generic;
using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using HornetsTraining.Training1.HomeWork.Haski;
using HornetsTraining.Training1.HomeWork.KrzysztofPater;
using HornetsTraining.Training1.HomeWork.LukaszSmierzchala;

namespace HornetsTraining.Training1.Generics.Factory
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