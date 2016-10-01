using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using HornetsTraining.Training1.HomeWork;
using Toci.HornetsTraining.Training1.HomeWork;

namespace HornetsTraining.Training1.HomeWork.ArnoldNowak
{
    public class ArnoldNowakStringOperations:StringOperations
    {
        public override string GetName()
        {
            return "Arnold Nowak";
        }

        public override string Substring(string candidate, int start, int length)
        {
            //zwraca wycinek stringu od start do dlugosci length
            // beatka, 1, 3=> "eat"
            var buffer = "";
            for (var i = start; i < start+length; i++)
            {
                buffer += candidate[i];
            }
            return buffer;
        }

        //zwraca pozycje stringu w stringu
        public override int PositionInString(string candidate, string needle)
        {
            int needleCounter = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle[needleCounter])
                {
                    needleCounter++;
                    if (needleCounter == needle.Length)
                    {
                        return i - needle.Length + 1;
                    }
                }
                else
                {
                    needleCounter = 0;
                }
            }
            return -1;
        }
        //zamienia string1 na string2
        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            if (PositionInString(candidate, needle)==-1)
            {
                return "błąd";
            }
            int position = PositionInString(candidate, needle);
            string buffer1 = Substring(candidate, 0, position);
            string buffer2 = Substring(candidate, position + needle.Length, candidate.Length-position-needle.Length);
            return buffer1 + replaceWith + buffer2;
        }
    }
}