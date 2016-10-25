namespace SeeSharpBasics.AndrzejIwanski
{
    public class AndrzejIwanskiStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = start; i < start + length; ++i)
            {
                result += candidate[i];
            }
            return result;
        }

        public override string GetName()
        {
            return "Andrzej Iwanski";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";
            for (int i = 0, j = candidate.Length - 1; i <= j; i++, j--)
            {
                if (i != j)
                {
                    result += candidate[i];
                    result += candidate[j];
                }
                else
                {
                    result += candidate[i];
                }
            }
            return result;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int occurences = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                    occurences++;
            }
            return occurences;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            int position;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    position = i;
                    return position;
                }
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
                {
                    result += candidate[i];
                }

            }
            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string result = "";
            int positionStart = positionInString(candidate, needle);
            if (positionStart == -1)
            {
                return "Brak napisu do podmiany!";
            }

            for (int i = 0; i < candidate.Length; i++)
            {
                if (i == positionStart || (i == positionStart && replace.Length == 0))
                {
                    result += replace;
                    i += needle.Length - 1;
                }
                else
                {
                    result += candidate[i];
                }
            }
            return result;
        }

        private int positionInString(string candidate, string needle)
        {
            int position;

            for (int i = 0; i < candidate.Length; ++i)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    } 
}