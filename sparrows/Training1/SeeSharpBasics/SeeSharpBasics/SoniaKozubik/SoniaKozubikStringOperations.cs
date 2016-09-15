using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.SoniaKozubik
{
    public class SoniaKozubikStringOperations : StringOperations
    {
        public override int CountOccurences(string candidate, char needle)
        {
            int result = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                    result++;
            }
            return result;
        }

        public override string GetName()
        {
            return "Sonia Kozubik";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";
            for (int i = 0, j = candidate.Length - 1; i < candidate.Length && i <= j; i++, j--)
            {
                if (i != j)
                    result = result + candidate[i] + candidate[j];
                else
                    result = result + candidate[i];
            }
            return result;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                    return i;

            }
            return -1;
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
                    result += candidate[i];
            }
            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string result = "";
            for (int i = 0; i < candidate.Length; i++)
            {

                if (Substring(candidate, i, needle.Length) == needle)
                {
                    result += replace;
                    i += needle.Length - 1;
                }

                else
                    result += candidate[i];
            }
            return result;
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
    }
}
