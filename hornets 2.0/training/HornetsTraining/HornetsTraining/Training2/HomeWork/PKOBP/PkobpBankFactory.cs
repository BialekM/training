using System;
using System.Collections.Generic;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork;

namespace HornetsTraining.Training2.HomeWork.PKOBP
{
    public class PkobpBankFactory : DelegateFactoryBase<TransferHandler>
    {
        public PkobpBankFactory()
        {
            ListOfInstances = BankList.GetBankList();
        }
    }
}