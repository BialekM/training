using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.Edwin
{
    class EdwinStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = 0; i < length; i++)
            {

                result += candidate[start];
                start++;
            }

            return result;
        }

        public override string GetName()
        {
            return "Edwin";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";
            int j = candidate.Length - 1;
            for (int i = 0; i < candidate.Length / 2; i++)
            {
                result = result + candidate[i] + candidate[j];
                j--;
            }
            if (candidate.Length % 2 == 0)
            {
                return result;
            }
            else
            {
                result = result + candidate[(candidate.Length / 2)];
                return result;
            }
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int result = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result++;
                }
            }
            return result;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            int result = -1;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result += replace;
                }
                else
                {
                    result += candidate[i];
                }
            }

            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {

                result += candidate[i];

            }

            return result + "   A tu mam problem";
        }
    }
}
