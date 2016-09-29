using System;
using System.Collections.Generic;
using System.Linq;

namespace Toci.HornetsTraining.Training1.HomeWork.BartoszMackiewicz
{
    public class BartoszMackiewiczStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Bartosz Mackiewicz";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i < start + length; i++)
            {
                result += candidate[i];
            }
            return result;
        }

        public override int PositionInString(string candidate, string needle)
        {
            if (candidate.Length < needle.Length) return -1;
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
            string subCandidate = candidate;
            int positionCounter = 0;



            while (PositionInString(subCandidate, needle) > -1)
            {

                positionCounter = PositionInString(subCandidate, needle);
                result += Substring(subCandidate, 0, positionCounter);
                result += replaceWith;
                subCandidate = Substring(subCandidate, positionCounter + needle.Length,
                    subCandidate.Length - (positionCounter+needle.Length));
            }

            result += subCandidate;
            return result;

        }

    }
}