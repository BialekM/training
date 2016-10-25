using System.Collections;

namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiBankResolver : BankResolver
    {
        public override string GetBankName(string bankCodeId)
        {
            Hashtable hashtableOfBanks = new Hashtable();
            hashtableOfBanks.Add(1010, "Narodowy Bank Polski");
            hashtableOfBanks.Add(1020, "PKO BP");
            hashtableOfBanks.Add(1030, "Citibank Handlowy");
            hashtableOfBanks.Add(1050, "ING");
            hashtableOfBanks.Add(1060, "BPH");
            hashtableOfBanks.Add(1090, "BZ WBK");
            hashtableOfBanks.Add(1130, "BGK");
            hashtableOfBanks.Add(1140, "mBank");
            hashtableOfBanks.Add(1160, "Bank Millennium");
            hashtableOfBanks.Add(1240, "Pekao");
            hashtableOfBanks.Add(1280, "HSBC");
            hashtableOfBanks.Add(1300, "Meritum Bank");
            hashtableOfBanks.Add(1320, "Bank Pocztowy");
            hashtableOfBanks.Add(1440, "Nordea Bank");
            hashtableOfBanks.Add(1470, "Eurobank");
            hashtableOfBanks.Add(1540, "BO�");
            hashtableOfBanks.Add(1580, "Mercedes-Benz Bank Polska");
            hashtableOfBanks.Add(1600, "BNP Paribas Fortis");
            hashtableOfBanks.Add(1610, "SGB - Bank");
            hashtableOfBanks.Add(1670, "RBS Bank (Polska)");
            hashtableOfBanks.Add(1680, "Plus Bank");
            hashtableOfBanks.Add(1750, "Raiffeisen Bank");
            hashtableOfBanks.Add(1840, "Societe Generale");
            hashtableOfBanks.Add(1870, "FM Bank PBP");
            hashtableOfBanks.Add(1910, "Deutsche Bank Polska");
            hashtableOfBanks.Add(1930, "Bank Polskiej Sp�dzielczo�ci");
            hashtableOfBanks.Add(1940, "Credit Agricole Bank Polska");
            hashtableOfBanks.Add(1950, "Idea Bank");
            hashtableOfBanks.Add(2000, "Rabobank Polska");
            hashtableOfBanks.Add(2030, "BG�");
            hashtableOfBanks.Add(2070, "FCE Bank Polska");
            hashtableOfBanks.Add(2120, "Santander Consumer Bank");
            hashtableOfBanks.Add(2130, "Volkswagen Bank");
            hashtableOfBanks.Add(2140, "Fiat Bank Polska");
            hashtableOfBanks.Add(2160, "Toyota Bank");
            hashtableOfBanks.Add(2190, "DnB Nord");
            hashtableOfBanks.Add(2480, "Getin Noble Bank");
            hashtableOfBanks.Add(2490, "Alior Bank");

            string bankName = "";
            int bankNumber = int.Parse(GetBankCodeForAccount(bankCodeId));

            if(hashtableOfBanks.ContainsKey(bankNumber))
            {
                bankName = (string) hashtableOfBanks[bankNumber];
            }
            else
            {
                return null;
            }

            return bankName;
        }


        public override string GetBankCodeForAccount(string account)
        {
            return account.Substring(2, 4);
        }
    }
}