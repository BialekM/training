using System;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.MarcinGala
{
    public class MarcinGalaStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            int j = start - 1;

            for (int i = 0; i < candidate.Length ; i++)
            {
                if ( i >= j  && i < j + length )
                {
                    result = result + candidate[i];
                }
            }
            return result;
        }

        public override string GetName()
        {

            return "Marcin Gała";
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
                result = result + candidate[candidate.Length / 2];
            }

            return result;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int result = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result += 1;
                }
            }
            return result;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            int pos = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    pos = i;
                    break;
                }
            }
            return pos;
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
                if (Substring(candidate, i, candidate.Length) == needle)
                {
                    result += replace;
                    i += needle.Length;
                }
                else
                {
                    result += candidate[i];
                }
            }
            return result;
        }
    }
}