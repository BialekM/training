namespace HornetsTraining.Training2.HomeWork
{
    public abstract  class TransferResolver
    {
        public virtual void DoTransfer(Transfer transfer)
        {
            //rzpoznac bank po numerze konta i powolac wlasciwa instancje, zrobic przelew
            // 10 1020 34243 // pkoi
            // 10 1050 342421 //mba
            // 10 1060 //ing

            MbankTransferHandler handler = new MbankTransferHandler();

            //handler.DoInTransfer()
        }
    }
}
