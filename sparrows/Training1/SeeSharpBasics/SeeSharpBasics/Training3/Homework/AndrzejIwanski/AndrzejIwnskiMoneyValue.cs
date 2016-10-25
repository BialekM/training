using System.Collections;

namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwnskiMoneyValue : MoneyValue
    {
        private Hashtable _onenessHashtable = new Hashtable
        {
            {0, "zero" },
            {1, "jeden"},
            {2, "dwa"},
            {3, "trzy"},
            {4, "cztery"},
            {5, "piec"},
            {6, "szesc"},
            {7, "siedem"},
            {8, "osiem"},
            {9, "dziewiec"},
            {10,"dziesiec" },
            {11, "jedynascie" },
            {12, "dwanascie" },
            {13, "trzynascie" },
            {14, "czternascie" },
            {15, "pietnascie" },
            {16, "szesnascie" },
            {17, "siedemnascie" },
            {18, "osiemnascie" },
            {19, "dziewietnascie" }
        };


        private Hashtable _tensHashtable = new Hashtable
        {
            {1, "dziesiec"},
            {2, "dwadziescia"},
            {3, "trzydziesci"},
            {4, "czterdziesci"},
            {5, "piecdziesiat"},
            {6, "szescdziesiat"},
            {7, "siedemdziesiat"},
            {8, "osiemdziesiat"},
            {9, "dziewiecdziesiat"},
        };

        private Hashtable _underTwentyHashtable = new Hashtable
        {
            
        };

        private Hashtable _hundredsHashtable = new Hashtable
        {
            {1, "sto"},
            {2, "dwiescie"},
            {3, "trzysta"},
            {4, "czterysta"},
            {5, "piecset"},
            {6, "szescset"},
            {7, "siedemset"},
            {8, "osiemset"},
            {9, "dziewiecset"},
        };

        private Hashtable _thousandsHashtable = new Hashtable
        {
            {1, "tysiąc"},
            {2, "dwiescie"},
            {3, "trzysta"},
            {4, "czterysta"},
            {5, "piecset"},
            {6, "szescset"},
            {7, "siedemset"},
            {8, "osiemset"},
            {9, "dziewiecset"},
        };

        public string _partOfString(string candidate)
        {



            return string.Empty;
        }

        public override string GetMoneyValue(string money)          //"1011
        {
            int dlugosc = money.Length;

            
            string result = "";


            return result;
        }
    }
}