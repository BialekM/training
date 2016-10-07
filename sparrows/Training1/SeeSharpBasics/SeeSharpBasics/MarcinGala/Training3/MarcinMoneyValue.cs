using System.Collections;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.MarcinGala.Training3
{
    public class MarcinMoneyValue : MoneyValue
    {
        private Hashtable Digits = new Hashtable
        {
            {1, "jeden"},
            {2, "dwa"},
            {3, "trzy"},
            {4, "cztery"},
            {5, "pięć"},
            {6, "sześć"},
            {7, "siedem"},
            {8, "osiem"},
            {9, "dziewięć"},
        };

        private Hashtable Dozens = new Hashtable
        {
            {10, "dziesięć"},
            {20, "dwadzieścia"},
            {30, "trzydzieści"},
            {40, "czterdzieści"},
            {50, "pięćdziesiąt"},
            {60, "sześćdziesiąt"},
            {70, "siedemdziesiąt"},
            {80, "osiemdziesiąt"},
            {90, "dziewięćdziesiąt"},
        };

        private Hashtable Hundreds = new Hashtable
        {
            {100, "sto"},
            {200, "dwieście"},
            {300, "trzysta"},
            {400, "czterysta"},
            {500, "pięćset"},
            {600, "sześćset"},
            {700, "siedemset"},
            {800, "osiemset"},
            {900, "dziewięćset"},
        };

        private Hashtable Thousand = new Hashtable()
        {
            {1000, "tysiąc" },
            {2000, "dwa tysiące" },
            {3000, "trzy tysiące" },
            {4000, "cztery tysiące" },
            {5000, "pięć tysięcy" },
            {6000, "sześć tysięcy" },
            {7000, "siedem tysięcy" },
            {8000, "osiem tysięcy" },
            {9000, "dziewięć tysięcy" },
        };



        public override string GetMoneyValue(string money)
        {

            int moneyLength = 0;
            string wynikSetek = "";
            string wynikDziesiatek = "";
            string wynikJednostek = "";
            string wynikTysiecy = "";
            string wynik = "";

            for (int i = 0; i < money.Length; i++)
            {
                moneyLength++;
            }

            if (moneyLength > 4)
            {
                wynik = "Podaj liczbe skladajaca sie z max 4 cyfr";
            }

            //jednostki
            if (moneyLength == 1)
            {
                wynikJednostek = Jednostki(money);
                wynik = wynikJednostek;
            }
            
            //dziesiątki
            if (moneyLength == 2)
            {
                wynikDziesiatek = Dziesiatki(money);
                wynikJednostek = Jednostki(money);
                wynik = wynikDziesiatek + " " + wynikJednostek;
            }

            //setki
            if (moneyLength == 3)
            {
                wynikSetek = Setki(money);
                wynikDziesiatek = Dziesiatki(money);
                wynikJednostek = Jednostki(money);
                wynik = wynikSetek + " " + wynikDziesiatek + " " + wynikJednostek;
            }

            //tysiące
            if (moneyLength == 4)
            {
                wynikTysiecy = Tysiace(money);
                wynikSetek = Setki(money);
                wynikDziesiatek = Dziesiatki(money);
                wynikJednostek = Jednostki(money);
                wynik = wynikTysiecy + " " + wynikSetek + " " + wynikDziesiatek + " " + wynikJednostek;
            }

            return wynik;
        }


        private string Tysiace(string moneyTysiac)
        {
            char[] tabMoney = moneyTysiac.ToCharArray();
            string temp = "";
            string txt = "";
            int tempToInt = 0;
            
            temp = tabMoney[0] + "000";
            tempToInt = int.Parse(temp);

            if (Thousand.ContainsKey(tempToInt))
            {
                txt += Thousand[tempToInt];
            }

            return txt;
        }


        private string Setki(string moneySetki)
        {
            char[] tabMoney = moneySetki.ToCharArray();
            string temp = "";
            string txt = "";
            int tempToInt = 0;

            if (tabMoney.Length == 4)
            {
                temp = tabMoney[1] + "00";
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 3)
            {
                temp = tabMoney[0] + "00";
                tempToInt = int.Parse(temp);
            }

            if (Hundreds.ContainsKey(tempToInt))
            {
                txt += Hundreds[tempToInt];
            }

            return txt;
        }

        private string Dziesiatki(string moneyDziesiatki)
        {
            char[] tabMoney = moneyDziesiatki.ToCharArray();
            string temp = "";
            string txt = "";
            int tempToInt = 0;

            if (tabMoney.Length == 4)
            {
                temp = tabMoney[2] + "0";
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 3)
            {
                temp = tabMoney[1] + "0";
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 2)
            {
                temp = tabMoney[0] + "0";
                tempToInt = int.Parse(temp);
            }

            if (Dozens.ContainsKey(tempToInt))
            {
                txt += Dozens[tempToInt];
            }

            return txt;
        }

        private string Jednostki(string moneyJednostki)
        {
            char[] tabMoney = moneyJednostki.ToCharArray();
            string temp = "";
            string txt = "";
            int tempToInt = 0;

            if (tabMoney.Length == 4)
            {
                temp = tabMoney[3].ToString();
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 3)
            {
                temp = tabMoney[2].ToString();
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 2)
            {
                temp = tabMoney[1].ToString();
                tempToInt = int.Parse(temp);
            }

            if (tabMoney.Length == 1)
            {
                temp = tabMoney[0].ToString();
                tempToInt = int.Parse(temp);
            }

            if (Digits.ContainsKey(tempToInt))
            {
                txt += Digits[tempToInt];
            }

            return txt;
        }
    }
}