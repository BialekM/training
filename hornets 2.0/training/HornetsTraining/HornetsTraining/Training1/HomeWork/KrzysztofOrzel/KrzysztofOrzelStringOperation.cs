using System;

namespace HornetsTraining.Training1.HomeWork.KrzysztofOrzel
{
    public class KrzysztofOrzelStringOperation : StringOperations
    {
        public override string GetName()
        {
            return "Krzysztof Orzel";
        }

        public override int PositionInString(string candidate, string needle)
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

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    result += replaceWith;
                    i += needle.Length - 1;
                }
                else
                {
                    result += candidate[i];
                }
            }

            return result;
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i < start + length && i < candidate.Length; i++)
            {
                result += candidate[i];
            }
            return result;
        }
    }
}