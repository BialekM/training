using System.Globalization;
using System.Runtime.Remoting.Messaging;

namespace SeeSharpBasics.KarolZareba
{
    public class KarolZarebaStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i <= length; i++)
            {
                result += candidate[i];
            }
            return result;

        }

        public override string GetName()
        {
            return "KarolZareba";

        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--)
            {
                result += candidate[i];
                result += candidate[j];
            }
            return result;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int result = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] = needle);
                {
                    result++;
                }
            }
            return result;
        }   
; 
        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new System.NotImplementedException();
        }
    }
}