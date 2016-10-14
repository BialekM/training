using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace SeeSharpBasics.PawelHanus
{
    public class PawelHanusStringOperations : StringOperations
    {
       
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = start; i < candidate.Length && i < start+length; i++)
            {
                result += candidate[i];
            }
            return result;
        }

        public override string GetName()
        {
            return "PawelHanus";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            int i = 0;
            int j = candidate.Length - 1;
            bool beginning = true;
            string glued = "";

            foreach (char c in candidate)
            {
                if (beginning)
                {
                    glued += candidate[i];
                    i++;
                    beginning = false;
                }
                else
                {
                    glued += candidate[j];
                    j--;
                    beginning = true;
                }               
            }

            return glued;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int count = 0;

            foreach (char c  in candidate)
            {
                if (c == needle)
                {
                    count++;
                }
            }

            return count;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            int position = -1;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    position = i;
                    break;
                }
            }
            return position;
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
                string substring = Substring(candidate, i, needle.Length);
                if (needle == substring && needle.Length != 0)
                {
                    result += replace;
                    i += needle.Length-1;
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
