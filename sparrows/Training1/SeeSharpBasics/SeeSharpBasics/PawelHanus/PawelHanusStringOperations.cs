using System;
using System.Runtime.Remoting.Messaging;

namespace SeeSharpBasics.PawelHanus
{
    public class PawelHanusStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = 0; i < candidate.Length - 1 || start + i < candidate.Length || i <= length; i++)
            {
                Console.WriteLine(candidate[i]);
            }

            return result;
        }

        public override string GetName()
        {
            return "PawelHanus";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new System.NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

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