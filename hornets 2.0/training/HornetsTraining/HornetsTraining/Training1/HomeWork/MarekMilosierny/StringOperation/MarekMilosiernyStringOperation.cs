namespace HornetsTraining.Training1.HomeWork.MarekMilosierny
{
    class MarekMilosiernyStringOperation : StringOperations
    {
        public override string GetName()
        {
            return "Marek Miłosierny";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            int stop = start + length;

            if (start < 0 || length <= 0 || start >= candidate.Length || length >= candidate.Length || start + length > candidate.Length)
            {
                return result;
            }

            for (int i = start; i < stop; i++)
            {
                result += candidate[i];
            }

            return result;
        }

        public override int PositionInString(string candidate, string needle)
        {
            for (int i = 0; i <= candidate.Length - 1; i++)
            {
                if (candidate[i] == needle[0])
                {
                    if (needle == Substring(candidate, i, needle.Length))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int replaceStart = PositionInString(candidate, needle);

            if (replaceStart < 0)
            {
                return candidate;
            }

            string firstPart = Substring(candidate, 0, replaceStart);
            string lastPart = Substring(candidate, replaceStart + needle.Length, candidate.Length - firstPart.Length - needle.Length);
            string result = firstPart + replaceWith + lastPart;

            return result;
        }
    }
}
