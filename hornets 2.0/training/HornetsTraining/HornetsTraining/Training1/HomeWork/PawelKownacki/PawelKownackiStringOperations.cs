namespace Toci.HornetsTraining.Training1.HomeWork.PawelKownacki
{
    public class PawelKownackiStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Pawel Kownacki";

        }

        public override string Substring(string candidate, int start, int length)
        {
            //return candidate.Substring(start, length);
            string substring = null;
            for (int i = start; i < length + start && i < candidate.Length; i++)
            {
                substring += candidate[i];
            }
            return substring;
        }

        public override int PositionInString(string candidate, string needle)
        {
            string substring = null;
            for (int i = 0; i < candidate.Length; i++)
            {
                substring = Substring(candidate, i, needle.Length);

                if (needle == substring) return i;
            }

            //return candidate.IndexOf(needle);
            return 0;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string replaced = null;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (Substring(candidate, i, needle.Length) == needle)
                {
                    replaced += replaceWith;
                    i += needle.Length - 1;
                }
                else
                {
                    replaced += candidate[i];
                }
            }

            return replaced;

            //return candidate.Replace(needle, replaceWith);

        }
    }
}