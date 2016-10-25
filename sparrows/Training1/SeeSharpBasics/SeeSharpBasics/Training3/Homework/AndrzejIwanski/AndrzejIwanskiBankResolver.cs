namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiBankResolver : BankResolver
    {
        public override string GetBankName(string bankCodeId)
        {
            string bankName = "";


            return bankName;
        }


        public override string GetBankCodeForAccount(string account)
        {
            var result = account.Substring(2, 4);
            return result;
        }
    }
}