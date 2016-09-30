using System.IO;
using Ninject.Activation.Strategies;

namespace Toci.HornetsTraining.Training2.HomeWork.KonradGalazka
{
    public class DnBNordTransferHandler  : TransferHandler
    {
        
        public override bool DoInTransfer(Transfer transfer)
        {
            StreamWriter _sw = new StreamWriter(@"..\..\Training2\HomeWork\LukaszCichon\HistoriaOperacji.txt", true);
            return true;
        }

        public override bool DoOutTransfer(Transfer transfer)
        {
            throw new System.NotImplementedException();
        }
    }
}