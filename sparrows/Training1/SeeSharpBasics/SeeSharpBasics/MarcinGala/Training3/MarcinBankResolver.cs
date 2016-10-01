using System.Collections;
using SeeSharpBasics.Training3.Homework;


namespace SeeSharpBasics.MarcinGala.Training3
{
   public class MarcinBankResolver : BankResolver
   {
        MarcinHashMap hm = new MarcinHashMap();

        public override string GetBankName(string bankCodeId)
        {
            Hashtable mapa = hm.Hashmap();
            string result = "";
            string bankId = GetBankCodeForAccount(bankCodeId);

            if (mapa.ContainsKey(bankId))
            {
                result += mapa[bankId];
            }
            else
            {
                result += "Bank nieprawidłowy w PL";
            }
            return "Twoj bank to" + result;
        }

        public override string GetBankCodeForAccount(string account)
        {
            string result = "";
            result += account.Substring(2, 4);
            return result;
        }
    }
}