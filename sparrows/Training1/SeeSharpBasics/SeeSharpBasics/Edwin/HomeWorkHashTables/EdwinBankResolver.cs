using System.Collections;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.Edwin.HomeWorkHashTables
{
    public class EdwinBankResolver : BankResolver
    {
        public override string GetBankName(string bankCodeId)
        {
            Hashtable BankCodes = new Hashtable();
            BankCodes.Add("1010", "Narodowy Bank Polski");
            BankCodes.Add("1020", "PKO BP");
            BankCodes.Add("1030", "Citibank Handlowy");
            BankCodes.Add("1050", "ING");
            BankCodes.Add("1060", "BPH");
            BankCodes.Add("1090", "BZ WBK");
            BankCodes.Add("1130", "BGK");
            BankCodes.Add("1140", "mBank");
            BankCodes.Add("1160", "Bank Millennium");
            BankCodes.Add("1240", "Pekao");
            BankCodes.Add("1280", "HSBC");
            BankCodes.Add("1300", "Meritum Bank");
            BankCodes.Add("1320", "Bank Pocztowy");
            BankCodes.Add("1440", "Nordea Bank");
            BankCodes.Add("1470", "Eurobank");
            BankCodes.Add("1540", "BOŚ");
            BankCodes.Add("1580", "Mercedes-Benz Bank Polska");
            BankCodes.Add("1600", "BNP Paribas Fortis");
            BankCodes.Add("1610", "SGB - Bank");
            BankCodes.Add("1670", "RBS Bank (Polska)");
            BankCodes.Add("1680", "Plus Bank");
            BankCodes.Add("1750", "Raiffeisen Bank");
            BankCodes.Add("1840", "Societe Generale");
            BankCodes.Add("1870", "FM Bank PBP");
            BankCodes.Add("1910", "Deutsche Bank Polska");
            BankCodes.Add("1930", "Bank Polskiej Spółdzielczości");
            BankCodes.Add("1940", "Credit Agricole Bank Polska");
            BankCodes.Add("1950", "Idea Bank");
            BankCodes.Add("2000", "Rabobank Polska");
            BankCodes.Add("2030", "BGŻ");
            BankCodes.Add("2070", "FCE Bank Polska");
            BankCodes.Add("2120", "Santander Consumer Bank");
            BankCodes.Add("2130", "Volkswagen Bank");
            BankCodes.Add("2140", "Fiat Bank Polska");
            BankCodes.Add("2160", "Toyota Bank");
            BankCodes.Add("2190", "DnB Nord");
            BankCodes.Add("2480", "Getin Noble Bank");
            BankCodes.Add("2490", "Alior Bank");

            string getNameResult;
            if (BankCodes.ContainsKey(bankCodeId))
            {
                getNameResult = (string)BankCodes[bankCodeId];
            }
            else
            {
                getNameResult = "Brak Kodu";
            }

            return getNameResult;
        }

        public override string GetBankCodeForAccount(string account)
        {
            EdwinStringOperations subS = new EdwinStringOperations();
            string removeWhiteSpace;
            string result;
            removeWhiteSpace = account.Replace(" ", ""); //usuniecie spacji z numeru konta
            result = subS.Substring(removeWhiteSpace, 2, 4); // wyciecie kodu banku

            return result;
        }
    }
}