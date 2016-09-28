using System.Collections.Generic;

namespace Toci.HornetsTraining.Training2.HomeWork.PKOBP
{
    public class PkobpTransferResolver : TransferResolver
    {
        public Dictionary<string, TransferHandler> TransferRecognizer;

        public PkobpTransferResolver()
        {
            TransferRecognizer = new Dictionary<string, TransferHandler>
            {
                {"1020", new PkobpTransferHandler()}
            };
        }
    }
}