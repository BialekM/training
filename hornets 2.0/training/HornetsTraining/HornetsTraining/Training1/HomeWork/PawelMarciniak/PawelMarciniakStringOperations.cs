using System;

namespace Toci.HornetsTraining.Training1.HomeWork.PawelMarciniak
{
    public class PawelMarciniakStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Pawel Marciniak";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = "";

            if ((!String.IsNullOrEmpty(candidate)) && (candidate.Length > length))
            {
                for (int i = start; i < start + length; i++)
                {
                    substring += candidate[i];
                }
            }

            return substring;
        }

        public override int PositionInString(string candidate, string needle)
        {
            if ((!String.IsNullOrEmpty(candidate)))
            {
                for (int i = 0; i < candidate.Length; i++)
                {
                    if (Substring(candidate, i, needle.Length) == needle)
                    {
                        return i;
                    }
                }

                return -1;
            }
            else
            {
                return -1;
            }
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string resultString = "";
            if ((!String.IsNullOrEmpty(candidate)) && (!String.IsNullOrEmpty(needle)))
            {
                for (int i = 0; i < candidate.Length; i++)
                {
                    if (Substring(candidate, i, needle.Length) == needle)
                    {
                        resultString += replaceWith;
                        i += needle.Length - 1;
                    }
                    else
                    {
                        resultString += candidate[i];
                    }
                }
            }
            return resultString;
        }
    }
}