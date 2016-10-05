using System;
using System.Collections.Generic;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace Toci.HornetsTraining.Training2.HomeWork.AdrianKoszyk.Eurobank
{
    public class EurobankFactory : DelegateFactoryBase<TransferHandler>
    {

        public EurobankFactory()
        {

            ListOfInstances = BankList.GetBankList();
        }
    }
}