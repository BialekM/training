using SeeSharpBasics.Training3.Homework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.SlawekNowinski.training3
{
    class SlawekNowinskiBankResolver : BankResolver
    {
        public override string GetBankCodeForAccount(string account)
        {
            return account.Substring(2, 4);
        }

        public override string GetBankName(string bankCodeId)
        {
            Hashtable result = new Hashtable();
            result.Add("1010", "Narodowy Bank Polski");
            result.Add("1020", "PKO BP");
            result.Add("1030", "Citibank Handlowy");
            result.Add("1050", "ING");
            result.Add("1060", "BPH");
            result.Add("1090", "BZ WBK");
            result.Add("1130", "BGK");
            result.Add("1140", "mBank");
            result.Add("1160", "Bank Millennium");
            result.Add("1240", "Pekao");
            result.Add("1280", "HSBC");
            result.Add("1300", "Meritum Bank");
            result.Add("1320", "Bank Pocztowy");
            result.Add("1440", "Nordea Bank");
            result.Add("1470", "Eurobank");
            result.Add("1540", "BOďż˝");
            result.Add("1580", "Mercedes-Benz Bank Polska");
            result.Add("1600", "BNP Paribas Fortis");
            result.Add("1610", "SGB - Bank");
            result.Add("1670", "RBS Bank (Polska)");
            result.Add("1680", "Plus Bank");
            result.Add("1750", "Raiffeisen Bank");
            result.Add("1840", "Societe Generale");
            result.Add("1870", "FM Bank PBP");
            result.Add("1910", "Deutsche Bank Polska");
            result.Add("1930", "Bank Polskiej Spďż˝dzielczoďż˝ci");
            result.Add("1940", "Credit Agricole Bank Polska");
            result.Add("1950", "Idea Bank");
            result.Add("2000", "Rabobank Polska");
            result.Add("2030", "BGďż˝");
            result.Add("2070", "FCE Bank Polska");
            result.Add("2120", "Santander Consumer Bank");
            result.Add("2130", "Volkswagen Bank");
            result.Add("2140", "Fiat Bank Polska");
            result.Add("2160", "Toyota Bank");
            result.Add("2190", "DnB Nord");
            result.Add("2480", "Getin Noble Bank");
            result.Add("2490", "Alior Bank");


            return result.ContainsKey(bankCodeId) ? result[bankCodeId].ToString() : "brak";

        }
    }
}
