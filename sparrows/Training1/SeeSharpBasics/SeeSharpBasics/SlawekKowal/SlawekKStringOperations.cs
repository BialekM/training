namespace SeeSharpBasics.SlawekKowal
{
    public class SlawekKStringOperations: StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string sub = "";
            for (int i = 0; i < length; i++)
            {
                sub += candidate[i + start];
            }
            return sub;
        }

        public override string GetName()
        {
            return "Sławek Kowal";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result="";
            for (int i = 0, j = candidate.Length - 1; i > j; i++, j--)
            {
                result += candidate[i] + candidate[j];
                if (i == j)
                {
                    result += candidate[i];
                }
            }
            return result;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int times = 0;
            foreach (char letter in candidate)
            {
                if (letter == needle) times++;
            }
            return times;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle) return i;
            }
            return -1;
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            string result = "";
            foreach (char letter in candidate)
            {
                if (letter == needle)
                {
                    result += replace;
                    
                }
                else
                {
                    result += letter;
                }
            }
            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string result = "";
            for (int i = 0; i < candidate.Length - replace.Length; i++)
            {
                if (Substring(candidate, i, replace.Length) == replace)
                {
                    result += replace;
                    i += replace.Length;
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