using System;
using System.Collections.Generic;

namespace Toci.HornetsTraining.Training1.HomeWork.LukaszCichon
{
    public class LukaszCichonStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Lukasz Cichon";
        }

        public override string Substring(string candidate, int start, int length)
        {
            if ((start + length <= candidate.Length))
            {
                string newCandidate = string.Empty;
                for (int i = start; i < start + length; i++)
                {
                    newCandidate += candidate[i].ToString();
                }
                return newCandidate;
            }
            else
            {
                return "ZleParametry";
            }
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
            int position=PositionInString(candidate, needle);

            if (position == -1)
            {
                return "NieMaCzegoPodmieniac";
            }

            string firstPart = Substring(candidate, 0, position);
            string secondPart = Substring(candidate, position + needle.Length, candidate.Length - firstPart.Length - needle.Length);

            return firstPart + replaceWith + secondPart;
            
        }
    }
}