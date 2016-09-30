namespace Toci.HornetsTraining.Training1.HomeWork.AndrzejIwanski
{
    public class AndrzejIwanskiStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Andrzej Iwanski";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = start; i < start + length; ++i)
            {
                result += candidate[i];
            }
            return result;
        }

        public override int PositionInString(string candidate, string needle)
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

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string result = "";
            int positionStart = PositionInString(candidate, needle);
            if (positionStart == -1)
            {
                return "Brak napisu do podmiany!";
            }

            for (int i = 0; i < candidate.Length; i++)
            {
                if (i == positionStart || (i == positionStart && replaceWith.Length == 0))
                {
                    result += replaceWith;
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