using System;
using System.Collections;
using System.Collections.Generic;

namespace HornetsTraining.Training1.HomeWork.TomaszGutowski
{
    public class TomaszGutowskiStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Tomasz Gutowski";
        }

        public override int PositionInString(string candidate, string needle)
        {


            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle[0])
                {
                    if (i + needle.Length > candidate.Length)
                    {
                        return -1;
                    }
                    else
                    {
                        if (Substring(candidate, i, needle.Length) == needle)
                        {
                            return i;
                        }
                    }
                }
            }

            return -1;



        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            if (PositionInString(candidate, needle) == -1)
            {
                return candidate;
            }
            else
            {
                string firstPart = Substring(candidate, 0, PositionInString(candidate, needle));
                string secondPart = Substring(candidate, PositionInString(candidate, needle) + needle.Length, candidate.Length - (PositionInString(candidate, needle) + needle.Length));

                return firstPart + replaceWith + secondPart;

            }
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = "";
            if (start + length <= candidate.Length)
            {
                for (int i = start; i < start + length; i++)
                {
                    substring += candidate[i];
                }
                return substring;
            }
            else
            {
                return "";
            }

        }
    }
}