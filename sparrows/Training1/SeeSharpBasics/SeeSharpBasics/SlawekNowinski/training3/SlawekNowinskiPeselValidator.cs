using System;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.SlawekNowinski.training3
{
    public class SlawekNowinskiPeselValidator : PeselValidator
    {
        public override bool IsPeselValid(string peselCandidate)
        {
            int[] pesel = new int[11];

            for (int i = 0; i < peselCandidate.Length; i++)
            {
                pesel[i] = (int)Char.GetNumericValue(peselCandidate[i]);
            }

            int control =
            1 * pesel[0] +
            3 * pesel[1] +
            7 * pesel[2] +
            9 * pesel[3] +
            1 * pesel[4] +
            3 * pesel[5] +
            7 * pesel[6] +
            9 * pesel[7] +
            1 * pesel[8] +
            3 * pesel[9];
            control = control % 10;
            return control == 10 - pesel[10] &&
                IsPeselDateValid(peselCandidate.Substring(0, 2), peselCandidate.Substring(2, 2), peselCandidate.Substring(4, 2)) ? true : false;
        }

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            if ((int.Parse(month) == 2 || int.Parse(month) == 22 || int.Parse(month) == 42 || int.Parse(month) == 82) && FebruarIsGood(year, day))
            {
                return true;
            }
            for (int i = 0; i < 100; i = i + 20)
            {
                if ((int.Parse(month) == 1 + i || int.Parse(month) == 3 + i || int.Parse(month) == 5 + i || int.Parse(month) == 7 + i ||
                    int.Parse(month) == 8 + i || int.Parse(month) == 10 + i || int.Parse(month) == 12 + i) && int.Parse(day) <= 31 && int.Parse(day) >= 1)
                {
                    return true;
                }
                if ((int.Parse(month) == 4 + i || int.Parse(month) == 6 + i ||
                     int.Parse(month) == 9 + i || int.Parse(month) == 11 + i) && int.Parse(day) <= 30 &&
                    int.Parse(day) >= 1)
                {
                    return true;
                }
            }
            return false;

        }

        private bool FebruarIsGood(string year, string day)
        {
            string month = "02";
            int[] leapYear = new int[25];
            leapYear[0] = 0;
            for (int i = 1; i < leapYear.Length; i++)
            {
                leapYear[i] = leapYear[i - 1] + 4;
            }

            foreach (int t in leapYear)
            {
                if (int.Parse(year) == t && int.Parse(day) > 29 && int.Parse(day) < 1)
                {
                    return false;
                }
                else if (int.Parse(day) > 28 && int.Parse(day) < 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}