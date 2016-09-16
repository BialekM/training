using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetsTraining.Training1.HomeWork.BartoszMackiewicz
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

            return ""; //TODO

        }
    }
}