
using Toci.HornetsTraining.Training2.HomeWork;
using Toci.HornetsTraining.Training1.Generics.Factory;


namespace Toci.HornetsTraining.Training2.HomeWork.BankMillenium
{
    public class BankMilleniumFactory : DelegateFactoryBase<TransferHandler>

    {

        public BankMilleniumFactory()
        {
            ListOfInstances = BankList.GetBankList();
        }
         
    }
}