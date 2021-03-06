﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;

namespace Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.Factory
{
    public class TransferHandlerFactory : DelegateFactoryBase<TransferHandler>
    {
        public TransferHandlerFactory()
        {
            ListOfInstances = new Dictionary<string, Func<TransferHandler>>
            {
                { "2160", () => new ToyotaBankTransferHandler() }
            };
        }
    }
}
