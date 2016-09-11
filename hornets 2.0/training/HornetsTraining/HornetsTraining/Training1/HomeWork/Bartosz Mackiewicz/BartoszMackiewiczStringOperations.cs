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

            

    }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int startIndex = PositionInString(candidate, needle);
            char[] candidateArray = candidate.ToCharArray(0, candidate.Length);
            char[] insertArray = replaceWith.ToCharArray(0, replaceWith.Length);

            List<char> candidateList = new List<char>(candidateArray.ToList());
            candidateList.RemoveRange(startIndex, needle.Length);
            candidateList.InsertRange(startIndex, insertArray);


            string result = new string(candidateList.ToArray());
            return result;



        }
    }
}