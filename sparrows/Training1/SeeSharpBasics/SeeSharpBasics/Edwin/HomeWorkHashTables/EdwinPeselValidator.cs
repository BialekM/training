using SeeSharpBasics.Training3.Homework;
using System;
using System.Linq;

namespace SeeSharpBasics.Edwin.HomeWorkHashTables
{
    public class EdwinPeselValidator : PeselValidator
    {
        public string peselYear;
        public string peselMonth;
        public string peselDay;
        
        
        public override bool IsPeselValid(string peselCandidate)
        {
            //sprawdzenie długości peselu
            if (peselCandidate.Length != 11)
            {
                return false;
            }

            EdwinStringOperations peselSub = new EdwinStringOperations();
            peselYear = peselSub.Substring(peselCandidate, 0, 2); // wyciecie roku z peselu
            peselMonth = peselSub.Substring(peselCandidate, 2, 2); // wyciecie miesiaca z peselu
            peselDay = peselSub.Substring(peselCandidate, 4, 2); // wyciecie dnia z peselu

            if (IsPeselDateValid(peselYear, peselMonth, peselDay) == false)
            {
                return false;
            }

            //string controlDigit = peselSub.Substring(peselCandidate, 10, 1);
            //int intSexDigit = int.Parse(peselSub.Substring(peselCandidate, 9, 1));
            //int digit1 = int.Parse(peselSub.Substring(peselCandidate, 0, 1));

            //wrzucenie do tablicy peselu
            int[] candidateTable = peselCandidate.Select(o => o - 48).ToArray();


            //wyliczenie sumy kontrolnej
            int controlDigit = 1 * candidateTable[0] + 3 * candidateTable[1] + 7 * candidateTable[2] + 9 * candidateTable[3] +
                                 1 * candidateTable[4] + 3 * candidateTable[5] + 7 * candidateTable[6] + 9 * candidateTable[7] +
                                 1 * candidateTable[8] + 3 * candidateTable[9];

            controlDigit = controlDigit % 10; // wyliczenie reszty z sumy kontrolnej


            if (controlDigit != 0)
            {
                controlDigit = 10 - controlDigit;
            }

            if (controlDigit != candidateTable[10])
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            int intYear = int.Parse(year);
            int intMonth = int.Parse(month);
            int intDay = int.Parse(day);

            if ((intYear >= 0 && intYear < 100) && (intMonth > 0 && intMonth < 13 ||
             intMonth > 20 && intMonth < 33 || intMonth > 40 && intMonth < 53 ||
             intMonth > 60 && intMonth < 73 || intMonth > 80 && intMonth < 93)
             && (intDay > 0 && intDay < 31))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}