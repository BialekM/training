using System;

namespace Toci.HornetsTraining.Training1.HomeWork.TomaszWilkosz
{
    public class TomaszWilkoszStringOperations  : StringOperations
    {
        public override string GetName()
        {
            return "Tomasz Wilkosz";
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
            string output = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (i <= candidate.Length - needle.Length && Substring(candidate, i, needle.Length) == needle)
                {
                    output += replaceWith;
                    i += needle.Length - 1;
                }
                else
                {
                    output += candidate[i];
                }
            }

            return output;
        }


        public override string Substring(string candidate, int start, int length)
        {
            string output = "";

            for (int i = start; i < start + length; i++)
            {
                output += candidate[i];
            }
            return output;
        }
    }
}