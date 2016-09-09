using System;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Microsoft.Win32;

namespace HornetsTraining.Training1.HomeWork.KrzysztofPater
{
    public class KrzysztofPaterStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Krzysztof Pater";
        }

        public override string Substring(string candidate, int start, int length)
        {
            //return (candidate.Substring(start, length));

            if ((start + length) <= candidate.Length)
            {
                string substring = "";
                for (int i = start; i < (start + length); i++)
                {
                    substring += candidate[i];
                }
                return (substring);
            }
            else
            {
                return ("Wartości start i length są za duże dla podanego ciągu znaków!");
            }

        }

        public override int PositionInString(string candidate, string needle)
        {
            //return (candidate.IndexOf(needle));

            string checkSubstring = "";

            int j = 0;
            for (int i = 0; i < (candidate.Length - needle.Length); i++)
            {
                for (j = i; j < (needle.Length + i); j++)
                {
                    checkSubstring += candidate[j];
                }

                if (checkSubstring == needle)
                {
                    return (j - needle.Length);
                }
                else
                {
                    checkSubstring = "";
                }
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int position = PositionInString(candidate, needle); ;
            string checkString = candidate;
            int l = checkString.Length;
            string beforeString = getBeforeString(candidate, position);
            string resultString = "";

            while (l > 0)
            {
                position = PositionInString(checkString, needle);
                Console.WriteLine("1." + checkString);
                if (position >= 0)
                {
                    checkString = trimCandidate(checkString, needle, position);
                    Console.WriteLine("2." + checkString);
                    l = checkString.Length;
                    resultString += replaceWith + checkString;//TODO: problem
                    Console.WriteLine("3." + resultString);
                }
                else
                {
                    l = 0;
                }
            }
            return beforeString + resultString;
        }

        private string getBeforeString(string candidate, int position)
        {
            string beforeString = "";
            for (int i = 0; i < position; i++)
            {
                beforeString += candidate[i];
            }
            return beforeString;
        }

        private string trimCandidate(string checkString, string needle, int position)
        {
            string trimString = "";
            for (int i = position + needle.Length; i < checkString.Length; i++)
            {
                trimString += checkString[i];
            }
            return trimString;
        }
    }
}