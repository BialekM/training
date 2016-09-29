using Toci.HornetsTraining.Training1.Generics.Factory;

namespace Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz
{
    public class BphBankFactory : DelegateFactoryBase<TransferHandler>
    {
        public BphBankFactory()
        {
            ListOfInstances = BankList.GetBankList();

        }
    }
}