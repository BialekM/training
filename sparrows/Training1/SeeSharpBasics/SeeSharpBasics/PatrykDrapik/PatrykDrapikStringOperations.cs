namespace SeeSharpBasics.PatrykDrapik
{
    public class PatrykDrapikStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = start; i < length + start && i < candidate.Length; i++)
            {
                result += candidate[i];
            }

            return result;
        }

        public override string GetName()
        {
            return "Patryk Drapik";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";

            for (int i = 0, y = candidate.Length - 1; i <= y; i++, y--)
            {
                if (i == y)

                {
                    result += candidate[i];
                }
                else
                {
                    result = result + candidate[i] + candidate[y];
                }
            }

            return result;
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int result = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                if (needle == candidate[i])
                {
                    result++;
                }
            }

            return result;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    return i;
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

            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle) // beatka ea eat => 
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
    }
}