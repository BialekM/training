using HornetsTraining.Training1.HomeWork;
using HornetsTraining.Training1.HomeWork.Adrian;
using HornetsTraining.Training1.HomeWork.BartekZapart;

namespace HornetsTraining.Training1.Generics.Factory
{
    public class StringOperationsFactory :  FactoryBase<IStringOperations>
    {
        public StringOperationsFactory()
        {
            ListOfInstances.Add("bartek", new BartekZapartStringOperations());
            ListOfInstances.Add("adrian", new AdrianStringOperations());
        }
    }
}