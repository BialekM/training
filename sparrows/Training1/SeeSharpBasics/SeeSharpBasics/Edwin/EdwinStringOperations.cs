namespace SeeSharpBasics.Edwin
{
    public class EdwinStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length) // wycina tekst od okreslonego miejsca
        {
            string result = "";
       
            for (int i = 0; i < length; i++)
            {

                    result += candidate[start];
                    start++;
            }

            return result;
        
        }

        public override string GetName() // zwraca imię
        {
            return "Edwin";
        }

        public override string GlueBeginingEnd(string candidate) // skleja skrajne litery od konca do poczatku
        {
            string result = "";
            int j = candidate.Length - 1;
            for (int i = 0; i < candidate.Length / 2; i++)
            {
                result = result + candidate[i] + candidate[j];
                j--;
            }
            if (candidate.Length % 2 == 0)
            {
                return result;
            }
            else
            {
                result = result + candidate[(candidate.Length / 2)];
                return result;
            }
        }

        public override int CountOccurences(string candidate, char needle) // zlicza wystapienia danej litery
        {
            int result = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result++;
                }
            }
            return result;
        }

        public override int LetterPositionInString(string candidate, char needle) // zwraca 1 pozycje wystąpienia danej litery
        {
            int result = -1;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        public override string LetterReplace(string candidate, char needle, char replace) // zamiana litery na wybrana litere
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result += replace;
                }
                else
                {
                    result += candidate[i];
                }
            }

            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {

                result += candidate[i];

            }

            return result + "   A tu mam problem";
        }
    }
}