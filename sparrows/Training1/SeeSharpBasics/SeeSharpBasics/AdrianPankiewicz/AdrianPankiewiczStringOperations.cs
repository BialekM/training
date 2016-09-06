
using System.CodeDom;
using System.Management.Instrumentation;

namespace SeeSharpBasics.AdrianPankiewicz
{
    public class AdrianPankiewiczStringOperations : StringOperations
    {
        public const string AdrianPankiewiczString = "Adrian Pankiewicz";

        public override string GetName()
        {
            return AdrianPankiewiczString;
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring = "";

            for (int i = start; i < start + length; i++)
                substring += candidate[i];

            return substring;
        }

        public override string GlueBeginingEnd(string candidate)
        {
            throw new System.NotImplementedException();
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int occurences = 0;

            for (int i = 0; i < candidate.Length; i++)
                if (candidate[i] == needle)
                    occurences++;

            return occurences;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
                if (candidate[i] == needle)
                    return i;

            throw new InstanceNotFoundException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            //while(CountOccurences(candidate, ))
            string lettersReplace = "";

            foreach (char t in candidate)
                if (t == needle)
                    lettersReplace += replace;
                else
                    lettersReplace += t;

            return lettersReplace;
        }


        public override string StringReplace(string candidate, string needle, string replace)
        {
            string stringReplace = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                
            }
        }
    }
}