namespace Toci.HornetsTraining.Training2.HomeWork.KonradGalazka
{
    public class KonradGalazkaTransferResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {
            string destBank = transfer.DestinationBankAccount.Substring(2, 4);
            var factory = new KonradGalazkaTransferHandlerFactory();
            TransferHandler inst = factory.GetInstance(destBank);

            inst.DoInTransfer(transfer);
        }
    }
}