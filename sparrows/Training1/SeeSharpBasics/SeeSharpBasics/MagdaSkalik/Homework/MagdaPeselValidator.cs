using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.MagdaSkalik.Homework
{
    public class MagdaPeselValidator : PeselValidator
    {
        public override bool IsPeselValid(string peselCandidate)
        {
            MagdaSkalikStringOperations sub = new MagdaSkalikStringOperations();
            bool result = false;
            bool resultDate = true;
            bool resultRest = true;
            string year = sub.Substring(peselCandidate, 0, 2);
            string month = sub.Substring(peselCandidate, 2, 2);
            string day = sub.Substring(peselCandidate, 4, 2);

            int[] peselDigit=new int[11];

            if(peselCandidate.Length >11)
            {
                return false;
            }

            for (int i = 0; i <= 10; i++)
            {
                int.TryParse(sub.Substring(peselCandidate, i, 1), out peselDigit[i]);

            }

            int sum;
            int sumContr;
            
            sum = 1 * peselDigit[0] + 3 * peselDigit[1] + 7 * peselDigit[2] +
                9 * peselDigit[3] + 1 * peselDigit[4] + 3 * peselDigit[5] +
                7 * peselDigit[6] + 9 * peselDigit[7] + 1 * peselDigit[8] +
                3 * peselDigit[9];

            sumContr = (10 - (sum % 10)) % 10;


            bool validPesel = IsPeselDateValid(year, month, day);

            if(!validPesel)
            {
                resultDate = false;
            }

            if(sumContr != peselDigit[10])
            {
                resultRest = false;
            }

            if(resultDate && resultRest)
            {
                result = true;
            }

            return result;
      
        }
        

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            bool result = true;
            int monthInt;
            Int32.TryParse(month, out monthInt);
            int dayInt;
            Int32.TryParse(day, out dayInt);
            if ((monthInt > 12 && monthInt < 21) 
                || (monthInt > 32 && monthInt < 41)
                || (monthInt > 52 && monthInt < 61)
                || (monthInt > 72 && monthInt < 81)
                || monthInt == 0)
            {
                result = false;
            }

            if((monthInt == 2 || monthInt == 22 || monthInt == 42 || monthInt == 62 || monthInt == 82) && dayInt >28)
            {
                result = false;
            }
            else if ((monthInt == 4 || monthInt == 24 || monthInt == 44 || monthInt == 64 || monthInt == 84 
                || monthInt == 6 || monthInt == 26 || monthInt == 46 || monthInt == 66 || monthInt == 86 
                || monthInt == 9 || monthInt == 29 || monthInt == 49 || monthInt == 69 || monthInt == 89
                || monthInt == 11 || monthInt == 31 || monthInt == 51 || monthInt == 71 || monthInt == 91) && dayInt > 30)
            {
                result = false;
            }
            else if (dayInt > 31)
            {
                result = false;
            }

            return result;
        }
    }
}
