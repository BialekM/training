using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training3.Homework;
using System.Collections;

namespace SeeSharpBasics.MagdaSkalik.Homework
{
    public class MagdaBankResolver : BankResolver
    {
        public override string GetBankCodeForAccount(string account)
        {
            throw new NotImplementedException();
        }

        public override string GetBankName(string bankCodeId)
        {
            string nameOfBank = "";
            Hashtable bankCode = new Hashtable();

            bankCode.Add("1010", "Narodowy Bank Polski");
            bankCode.Add("1011", "Narodowy Bank Polski");
            bankCode.Add("1020", "PKO BP");
            bankCode.Add("1030", "Citibank Handlowy");
            bankCode.Add("1050", "ING");
            bankCode.Add("1060", "BPH");
            bankCode.Add("1090", "BZ WBK");
            bankCode.Add("1130", "BGK");
            bankCode.Add("1140", "mBank");
            bankCode.Add("1160", "Bank Millennium");
            bankCode.Add("1240", "Pekao");
            bankCode.Add("1280", "HSBC");
            bankCode.Add("1300", "Meritum Bank");
            bankCode.Add("1320", "Bank Pocztowy");
            bankCode.Add("1440", "Nordea Bank");
            bankCode.Add("1470", "Eurobank");
            bankCode.Add("1540", "BOŚ");
            bankCode.Add("1580", "Mercedes-Benz Bank Polska");
            bankCode.Add("1600", "BNP Paribas Fortis");
            bankCode.Add("1610", "SGB - Bank");
            bankCode.Add("1670", "RBS Bank (Polska)");
            bankCode.Add("1680", "Plus Bank");
            bankCode.Add("1750", "Raiffeisen Bank");
            bankCode.Add("1840", "Societe Generale");
            bankCode.Add("1870", "FM Bank PBP");
            bankCode.Add("1910", "Deutsche Bank Polska");
            bankCode.Add("1930", "Bank Polskiej Spółdzielczości");
            bankCode.Add("1940", "Credit Agricole Bank Polska");
            bankCode.Add("1950", "Idea Bank");
            bankCode.Add("2000", "Rabobank Polska");
            bankCode.Add("2030", "BGŻ");
            bankCode.Add("2070", "FCE Bank Polska");
            bankCode.Add("2120", "Santander Consumer Bank");
            bankCode.Add("2130", "Volkswagen Bank");
            bankCode.Add("2140", "Fiat Bank Polska");
            bankCode.Add("2160", "Toyota Bank");
            bankCode.Add("2190", "DnB Nord");
            bankCode.Add("2480", "Getin Noble Bank");
            bankCode.Add("2490", "Alior Bank");


            if (bankCode.ContainsKey(bankCodeId))
            {
                nameOfBank = (string)bankCode[bankCodeId];
            }
            else
            {
                nameOfBank = "Brak kodu, lubbłędny kod";
            }

            return nameOfBank;
        }
    }
}
