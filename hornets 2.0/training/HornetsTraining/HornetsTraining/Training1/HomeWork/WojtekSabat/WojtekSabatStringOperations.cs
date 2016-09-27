namespace Toci.HornetsTraining.Training1.HomeWork.WojtekSabat
{
    public class WojtekSabatStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Wojtek Sabat";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string substring="";
            for (int i = 0; i < length; i++)
                substring += candidate[start++];
            return substring;
        }

        public override int PositionInString(string candidate, string needle)
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

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            var needlePosition = PositionInString(candidate, needle);
            var endStringPosition = needlePosition + needle.Length;
            var startString = Substring(candidate, 0, needlePosition);
            var endString = Substring(candidate,endStringPosition, candidate.Length - endStringPosition);
            return startString + replaceWith + endString;
        }
    }
}