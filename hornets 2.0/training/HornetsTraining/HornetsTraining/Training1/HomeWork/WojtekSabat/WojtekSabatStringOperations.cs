using System.CodeDom;

namespace HornetsTraining.Training1.HomeWork.WojtekSabat
{
    public class WojtekSabatStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Wojtek Sabat";
        }

        public override string Substring(string candidate, int start, int length) // zwraca wycinek stringu od start do dlugosci length: beatka, 1, 3 => eat
        {
            string substring="";
            for (int i = 0; i < length; i++)
            {
                substring += candidate[start++];
            }
            return substring;
        }

        public override int PositionInString(string candidate, string needle) // pozycja stringu w stringu
        {
            for (int position = 0; position < candidate.Length; position++)
            {
                if (candidate[position] != needle[0])
                    continue;
                if(Substring(candidate, position, needle.Length)==needle)
                    return position;
            }
            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith) // podmieinc string w stringu beata, at, atk => beatka
        {
            var startNeedlePosition = PositionInString(candidate, needle);
            var endStringPosition = startNeedlePosition + needle.Length;
            var startString = Substring(candidate, 0, startNeedlePosition);
            var endString = Substring(candidate,endStringPosition, candidate.Length - endStringPosition);
            return startString+replaceWith+endString;
        }
    }
}