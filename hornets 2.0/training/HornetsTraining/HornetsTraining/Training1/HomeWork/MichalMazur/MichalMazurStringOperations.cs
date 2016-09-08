using System;
namespace HornetsTraining.Training1.HomeWork.MichalMazur
{
    public class MichalMazurStringOperations : StringOperations
    {
        struct NeedlePosition
        {
            public bool findStringInString;
            public int count;
        }
        public override string GetName()
        {
            return "Michal Mazur";

        }

        public override string Substring(string candidate, int start, int lenght)
        {
            string temp = "";

            if (candidate.Length < 1)
                throw new Exception("empty string candidate");
            if (start < 0 || start > candidate.Length)
                throw new Exception("incorrect start point");


            for (int count = 0; count < lenght; count++, start++)
            {
                if (start >= candidate.Length)
                    break;
                temp += candidate[start];

            }

            return temp;
        }

        public override int PositionInString(string candidate, string needle)
        {

            if (candidate.Length < needle.Length)
                throw new Exception("candidate string is shorter than needle string");

            NeedlePosition position = CheckNeedle(candidate, needle);
            if (position.findStringInString != true)
                throw new Exception("not found needle string in candidate");
            return position.count;
        }


        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string stringChagned = "";

            if (candidate.Length < needle.Length)
                throw new Exception("candidate string is shorter than needle string");

            NeedlePosition position = CheckNeedle(candidate, needle);

            if (position.findStringInString != true)
                throw new Exception("not found needle string in candidate");

            //for przepisujący z candidate do needle
            for (int stringChagnedCount = 0; stringChagnedCount < position.count; stringChagnedCount++)
                stringChagned += candidate[stringChagnedCount];

            //dopisanie stringa replaceWith
            stringChagned += replaceWith;

            //przepisanie od zakończenia stringa needle, do końca stringa candidate
            for (int stringChagnedCount = position.count + needle.Length; stringChagnedCount < candidate.Length; stringChagnedCount++)
                stringChagned += candidate[stringChagnedCount];

            return stringChagned;
        }



        private NeedlePosition CheckNeedle(string candidate, string needle)
        {

            NeedlePosition needlePosition;

            int needleCount = 0;
            int count = 0;
            bool findStringInString = false;

            if (candidate.Length < needle.Length)
                throw new Exception("candidate string is shorter than needle string");

            // for przeglądający cały string candidate
            for (count = 0; count < candidate.Length; count++)
            {
                //porównywanie pierwszego znaku z needle, ze znakami wystepującymi w candidate
                if (candidate[count] == needle[needleCount])
                {
                    //for sprawdzający czy występuje cały string needle w candidate
                    for (int secondCount = 0; secondCount < needle.Length; secondCount++, needleCount++)
                    {
                        if (candidate[count + secondCount] == needle[needleCount])
                            findStringInString = true;
                        else
                        {
                            findStringInString = false;
                            needleCount = 0;
                            break;
                        }
                    }

                }
                // jeśli wystepuje, przerywamy dalsze szukanie
                if (findStringInString == true)
                    break;
            }

            needlePosition.count = count;
            needlePosition.findStringInString = findStringInString;

            return needlePosition;
        }
    }
}