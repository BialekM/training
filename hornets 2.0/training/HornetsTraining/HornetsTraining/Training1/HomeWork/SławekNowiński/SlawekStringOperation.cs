namespace HornetsTraining.Training1.HomeWork.SławekNowiński
{
    public class SlawekStringOperation :StringOperations
    {
        public override string GetName()
        {
            return "Slawomir Nowinski";
        }

        public override string Substring(string candidate, int start, int lenght)
        {
            string solution = "";
            for (int i = start; i <= lenght; i++)
                solution += candidate[i];
            return solution;
        }

        public override int PositionInString(string candidate, string needle)
        {
            int solution = 0;
            while (solution <= candidate.Length)
            {
                if (candidate[solution] == needle[solution])
                    if (Substring(candidate, solution, needle.Length) == needle)
                        return solution;
                solution++;
            }
            return solution;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string solution = "";

            for (int i = 0; i <= candidate.Length + replaceWith.Length - needle.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) != needle)
                    solution += candidate;
                else
                {
                    solution += replaceWith;
                    i = i + needle.Length - 1;
                }


            }

            return solution;
        }
    }
}
