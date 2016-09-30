using System;
using System.Collections.Generic;
using HornetsTraining.Training1.Generics.Factory;

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