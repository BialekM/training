using System;
using System.Runtime.InteropServices;

namespace Toci.HornetsTraining.Training1.HomeWork.RafalKawalerski
{
    public class RafalKawalerskiStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Rafal Kawalerski";
        }

        public override string Substring(string candidate, int start, int length)
        {
            var text = "";
            if (candidate.Length - start < length)
                return "Za duza wartosc length";
            for (int i = start; i < start + length; i++)
                text += candidate[i];

            return text;
        }

        public override int PositionInString(string candidate, string needle)
        {

            if (string.IsNullOrEmpty(candidate) || string.IsNullOrEmpty(needle))
                return -1;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle[0])
                {
                    return i;
                }
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            var endOfFirstPart = PositionInString(candidate, needle);
            var firstPart = Substring(candidate, 0, endOfFirstPart);
            var textReplace = firstPart + replaceWith;
            var endOfEnd = endOfFirstPart + needle.Length;
            var candidateLength = candidate.Length;
            var text = "";

            if (endOfEnd == candidateLength)
            {
                text = textReplace;
            }
            else
            {
                var endPart = Substring(candidate, endOfEnd, candidateLength - endOfEnd);
                text = textReplace + endPart;
            }

            return text;
        }
    }
}