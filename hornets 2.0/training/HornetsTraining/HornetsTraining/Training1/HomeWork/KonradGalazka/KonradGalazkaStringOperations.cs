namespace Toci.HornetsTraining.Training1.HomeWork.KonradGalazka
{
    public class KonradGalazkaStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Konrad Gałązka";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string subWord = "";
            //pobierz candidate
            //zaznacz gdzie ma sie zaczynać wycinanie
            //wytnij tyle, ile wynosi długość length
            for (int i = 0; i < candidate.Length; i++)
            {
                if (i == start)
                {
                    for (int j = 0; j < length; j++)
                    {
                        subWord = subWord + "" + candidate[i];
                        i++;
                    }
                }
            }

            return subWord;
        }

        public override int PositionInString(string candidate, string needle)
        {
            for (int i = 0, ndle = 0; i < candidate.Length; i++)
            {
                if (candidate[i] != needle[ndle])
                {
                    ndle = 0;
                }
                else
                {
                    ndle++;
                    if (ndle == needle.Length)
                    {
                        return i - needle.Length + 1;
                    }
                }
            }
            return -1;
        }

        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            string newWord = "";
            int ndle = 0;

            for (int i = 0; i < candidate.Length; i++)
            {

                if (candidate[i] != needle[ndle])
                {
                    ndle = 0;
                    newWord = newWord + candidate[i];
                }
                else
                {
                    for (ndle = 0; ndle < replaceWith.Length; ndle++)
                    {
                        newWord = newWord + replaceWith[ndle];
                    }
                    ndle = 0;
                }
            }

            return newWord;
        }
    }
}