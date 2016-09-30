using System;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Microsoft.Win32;

namespace Toci.HornetsTraining.Training1.HomeWork.KrzysztofPater
{
    public class KrzysztofPaterStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Krzysztof Pater";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = "";
            for (int i = start; i < start + length && i < candidate.Length; i++)
            {
                substring += candidate[i];
            }
            return substring;
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
            string resultString = "";
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
            return resultString;
        }

    }
}