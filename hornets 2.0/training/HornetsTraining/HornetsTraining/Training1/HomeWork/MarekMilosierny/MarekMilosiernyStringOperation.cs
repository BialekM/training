namespace Toci.HornetsTraining.Training1.HomeWork.MarekMilosierny
{
    public class MarekMilosiernyStringOperation : StringOperations
    {
        public override string GetName()
        {
            return "Marek Miłosierny";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            int stop = start + length;

            if (start < 0 || length <= 0 || start >= candidate.Length || length >= candidate.Length 
                || start + length > candidate.Length)
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
            if (needle == "")
            {
                return -1;
            }

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
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    result += replaceWith;
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
