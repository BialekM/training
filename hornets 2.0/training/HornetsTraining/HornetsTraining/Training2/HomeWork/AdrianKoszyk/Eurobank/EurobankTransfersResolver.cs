using System.Runtime.InteropServices;

namespace Toci.HornetsTraining.Training2.HomeWork.AdrianKoszyk.Eurobank
{
    public class EurobankTransfersResolver : TransferResolver
    {
        public override void DoTransfer(Transfer transfer)
        {

            var handler = GetBank(transfer);

            handler.DoInTransfer(transfer);
            handler.DoOutTransfer(transfer);
            
        }


        private TransferHandler GetBank(Transfer transfer)
        {
            var list = BankList.GetBankList();
            var key = GetBankId(transfer.SourceBankAccount);
            return list[key]();
        }

      

        public string GetBankId(string number)
        {

            return number.Substring(2, 4);
        }

    }
}