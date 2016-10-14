using SeeSharpBasics.Training5;

namespace SeeSharpBasics.SlawekNowinski
{
    public class SlawekNowinskiHomework : Homework
    {
        public override string StringReverse(string candidate)
        {
            string result = "";
            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result += candidate[i];
            }
            return null;
        }

        public override string Substring(string candidate, int start, int length)
        {
            string solution = "";
            for (int i = start; i < length + start; i++)
            {
                solution += candidate[i];
            }
            return solution;

        }
    }
}