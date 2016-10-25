using System;

namespace SeeSharpBasics.Training3.Homework.AndrzejIwanski
{
    public class AndrzejIwanskiPeselValidator : PeselValidator
    {
        public override bool IsPeselValid(string peselCandidate)
        {
            IsPeselDateValid(peselCandidate.Substring(0, 2), peselCandidate.Substring(2, 2),
                peselCandidate.Substring(4, 2));

            int[] peselNumbers = new int[11];

            for (int i = 0; i < 11; i++)
            {
                peselNumbers[i] = (int)Char.GetNumericValue(peselCandidate[i]);
            }

            int suma = peselNumbers[0] + 3 * peselNumbers[1] + 7 * peselNumbers[2] + 9 * peselNumbers[3] +
                       peselNumbers[4] + 3 * peselNumbers[5] + 7 * peselNumbers[6] + 9 * peselNumbers[7] +
                       peselNumbers[8] + 3 * peselNumbers[9];

            return (10 - (suma - (suma / 10) * 10)) == peselNumbers[10];
        }

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            return true;
        }
    }
}