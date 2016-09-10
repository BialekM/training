using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.Adrian;
using HornetsTraining.Training1.HomeWork.AdrianPankiewicz;
using HornetsTraining.Training1.HomeWork.BartekZapart;
using HornetsTraining.Training1.HomeWork.BartoszMackiewicz;

namespace HornetsTraining.Training1.Generics.Factory
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