using System;
namespace HornetsTraining.Training1.HomeWork.MichalMazur
{
    public class MichalMazurStringOperations : StringOperations
    {
      
        public override string GetName()
        {
            return "Michal Mazur";

        }

        public override string Substring(string candidate, int start, int lenght)
        {
            string temp = "";

            if (candidate.Length < 1)
                throw new Exception("empty string candidate");
            if (start < 0 || start > candidate.Length)
                throw new Exception("incorrect start point");


            for (int count = 0; count < lenght; count++, start++)
            {
                if (start >= candidate.Length)
                    break;
                temp += candidate[start];

            }

            return temp;
        }

        public override int PositionInString(string candidate, string needle)
        {

            for(int count = 0; count < candidate.Length; count++)
            {
                if (Substring(candidate, count, needle.Length)==needle)
                {
                    return count;
                }
            }

            return -1;
        }


        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string stringFirstHalf= "";
            string stringSecondtHalf= "";
            string stringAll = candidate;
            int positionNeedle = 0;
            bool repleacing = true;

            while (repleacing==true)
            {
                if ((positionNeedle = PositionInString(stringAll, needle)) != -1)
                {
                    stringFirstHalf = apeendString(stringAll, 0, positionNeedle);
                    stringSecondtHalf = apeendString(stringAll, stringFirstHalf.Length + needle.Length,candidate.Length);
                    stringFirstHalf += replaceWith;
                    stringFirstHalf += stringSecondtHalf;
                    stringAll = stringFirstHalf;
                }
                else
                {
                    repleacing = false;
                }
            }
            return (stringAll == candidate) ? null: stringAll;
        }

        private string apeendString(string s, int start, int end)
        {
            string temp = "";
            for (int i = start; i < end; i++)
            {
                temp += s[i];
            }
            return temp;
        }

       
    }
}