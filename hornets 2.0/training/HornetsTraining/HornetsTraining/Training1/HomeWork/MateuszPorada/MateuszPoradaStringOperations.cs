using System.IO;

namespace HornetsTraining.Training1.HomeWork.MateuszPorada
{
    public class MateuszPoradaStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Mateusz Porada";
        }

        public override string Substring(string candidate, int start, int length)
        {
            var substring = "";

            if (length + start <= candidate.Length)
            {
                for (int i = start; i < length + start; i++)
                {
                    substring += candidate[i];
                }
                return substring;
            }
            else
            {
                return "Zbyt długi ciąg znaków!";
            }
        }

        public override int PositionInString(string candidate, string needle)
        {
            if (string.IsNullOrEmpty(candidate) || string.IsNullOrEmpty(needle))
                return -1;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle[0])
                {
                    return i;
                }
            }

            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {

            int position = PositionInString(candidate, needle);
            string start = Substring(candidate, 0, position);
            int end = position + needle.Length;
            string replace = start + replaceWith;
            string text = "";

            if (end == candidate.Length)
            {
                text = replace;
            }
            else
            {
                var ending = Substring(candidate, end, candidate.Length - end);
                text = replace + ending;
            }
            return text;
        }
    }
}