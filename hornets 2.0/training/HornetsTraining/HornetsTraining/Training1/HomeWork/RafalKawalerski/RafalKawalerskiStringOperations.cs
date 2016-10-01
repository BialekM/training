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
                if (Substring(candidate, i , needle.Length) == needle)
                {
                    return i;
                }
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string text = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    text += replaceWith;
                    i += needle.Length - 1;
                }
                else
                {
                    text += candidate[i];
                }
            }

            return text;
        }
    }
}