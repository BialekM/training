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
            string checkSubstring = "";
            string firstString = "";
            string lastString = "";

            int j;
            for (int i = 0; i <= (candidate.Length - needle.Length); i++)
            {
                for (j = i; j < (needle.Length + i); j++)
                {
                    checkSubstring += candidate[j];
                }

                if (checkSubstring == needle)
                {
                    for (int k = 0; k < (j - needle.Length); k++)
                    {
                        firstString += candidate[k];
                    }

                    for (int l = j; l < candidate.Length; l++)
                    {
                        lastString += candidate[l];
                    }
                }
                else
                {
                    checkSubstring = "";
                }

            }
            if (firstString != "" || lastString != "")
            {
                return (firstString + replaceWith + lastString);
            }
            else
            {
                return ("Podany ciąg nie istnieje! ");
            }
        }
    }
}