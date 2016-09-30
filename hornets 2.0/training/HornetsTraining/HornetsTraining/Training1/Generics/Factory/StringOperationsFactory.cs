using Toci.HornetsTraining.Training1.HomeWork.Adrian;
using Toci.HornetsTraining.Training1.HomeWork.BartekZapart;
using Toci.HornetsTraining.Training1.HomeWork;
using Toci.HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using Toci.HornetsTraining.Training1.HomeWork.BartoszMackiewicz;

namespace Toci.HornetsTraining.Training1.Generics.Factory
{
    public class StringOperationsFactory :  FactoryBase<IStringOperations>
    {
        public StringOperationsFactory()
        {
            ListOfInstances.Add("bartek", new AdrianPankiewiczStringOperations());
            ListOfInstances.Add("adrian", new BartoszMackiewiczStringOperations());
        }
    }
}