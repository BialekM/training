using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HornetsTraining.Training1.Generics.Factory;
using HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training1.Generics.Factory;

namespace HornetsTraining.Training2.HomeWork.LukaszSmierzchala.Factory
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
