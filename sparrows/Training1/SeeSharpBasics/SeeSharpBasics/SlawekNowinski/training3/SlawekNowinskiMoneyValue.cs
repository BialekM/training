using System.Collections;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.SlawekNowinski.training3
{
    public class SlawekNowinskiMoneyValue : MoneyValue
    {
        private Hashtable Digits = new Hashtable();
        public override string GetMoneyValue(string money) // źle działa niedokończone
        {
            string result = "";
            for (int i = money.Length - 1; i >= 0; i--)
            {


                if (i == 0 && money[1] != '1')
                {
                    result += Digits[money[i]];
                }
                if (i == 1)
                {
                    result += One(money);
                }
                if (i == 2)
                {
                    result += Two(money);
                }
                if (i == 3)
                {
                    result += Thre(money);
                }
                if (i == 4)
                {
                    result += Four(money);
                }
                if (i == 5)
                {
                    result += Five(money);
                }
                if (i == 6)
                {
                    result += Six(money);
                }
                if (i == 7)
                {
                    result += Seven(money);
                }
                if (i == 8)
                {
                    result += Eight(money);
                }
            }
            return result;
        }
        private string One(string money)
        {
            string result = "";
            if (money[1] != '1')
            {
                result += Digits[money[1]];
            }
            if (money[1] == '1' && money[0] != '0')
            {
                result += Digits[money[1]] + "nascie";
            }
            if (money[1] == '1' && money[0] == '0')
            {
                result += Digits[money[1]] + "dziesiec";
            }
            if (money[1] == '2' || money[1] == '3' || money[1] == '4')
            {
                result += Digits[money[1]] + "dziesci";
            }
            if (money[1] == '5' || money[1] == '6' || money[1] == '7' || money[1] == '8' || money[1] == '9')
            {
                result += Digits[money[1]] + "dziesiat";
            }
            return result;
        }

        private string Two(string money)
        {
            string result = "";
            if (money[2] != '1' && money[2] != '2' && money[2] != '3' && money[2] != '4')
            {
                result += Digits[money[2]] + "set";
            }
            if (money[2] == '2')
            {
                result += Digits[money[2]] + "scie";
            }
            if (money[2] == '3' || money[2] == '4')
            {
                result += "sta";
            }
            return result;
        }

        private string Thre(string money)
        {
            string result = "";

            if (money[3] != '1')
            {
                result += Digits[money[3]] + "tysiace";
            }
            if (money[3] == '1')
            {
                result += "tysiac";
            }

            return result;
        }

        private string Four(string money)
        {
            string result = "";
            if (money[4] == '1' && money[4 - 1] == '0')
            {
                result += Digits[money[4]] + "dziesiec";
            }
            if (money[4] == '2' || money[4] == '3' || money[4] == '4')
            {
                result += Digits[money[4]] + "dziesci";
            }
            if (money[4] == '5' || money[4] == '6' || money[4] == '7' || money[4] == '8' || money[4] == '9')
            {
                result += Digits[money[4]] + "dziesiat";
            }
            return result;
        }

        private string Five(string money)
        {
            string result = "";
            if (money[5] != '1' && money[5] != '2' && money[5] != '3' && money[5] != '4')
            {
                result += Digits[money[5]] + "set";
            }
            if (money[5] == '2')
            {
                result += Digits[money[5]] + "scie";
            }
            if (money[5] == '3' || money[5] == '4')
            {
                result += Digits[money[5]] + "sta";
            }
            return result;
        }

        private string Six(string money)
        {
            string result = "";
            if (money[6] == '1')
            {
                result += "milion";
            }
            if (money[6] == '2' || money[6] == '3' || money[6] == '4')
            {
                result += Digits[money[5]] + "miliony";
            }
            if (money[6] == '5' || money[6] == '6' || money[6] == '7' || money[6] == '8' || money[6] == '9')
            {
                result += Digits[money[5]] + "miliow";
            }
            return result;
        }

        private string Seven(string money)
        {
            string result = "";
            if (money[7] == '1' && money[6] != '0')
            {
                result += Digits[money[7]] + "nascie";
            }
            if (money[7] == '1' && money[6] == '0')
            {
                result += Digits[money[7]] + "dziesiec";
            }
            if (money[7] == '2' || money[7] == '3' || money[7] == '4')
            {
                result += Digits[money[7]] + "dziesci";
            }
            if (money[7] == '5' || money[7] == '6' || money[7] == '7' || money[7] == '8' || money[7] == '9')
            {
                result += Digits[money[7]] + "dziesiat";
            }
            return result;
        }

        private string Eight(string money)
        {
            string result = "";
            if (money[8] != '1' && money[8] != '2' && money[8] != '3' && money[8] != '4')
            {
                result += Digits[money[8]] + "set";
            }
            if (money[8] == '2')
            {
                result += Digits[money[8]] + "scie";
            }
            if (money[8] == '3' || money[8] == '4')
            {
                result += "sta";
            }
            return result;
        }
    }
}