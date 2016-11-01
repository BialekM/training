using System;

namespace SeeSharpBasics.Olek
{
    public class OlekStringOperations : StringOperations

    {
        public override string Substring(string candidate, int start, int length)
        {
            //throw new System.NotImplementedException();
            string result = "";

            //Substring("beatka", 1, 3); eat
            //Substring("bartek", 2, 4); rtek
            //Substring("aleksander", 5, 2);  an
            for (int i = start; i < start + length; i++)
            {
                result += candidate[i].ToString();
                Console.Write(result);
            }
            return result;
        }

        public override string GetName()
        {
            throw new System.NotImplementedException();
        }

        public override string GlueBeginingEnd(string candidate)
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
                Console.WriteLine("ilość parzysta znaków - " + result);
                return result;
            }
            else
            {
                result = result + candidate[(candidate.Length / 2)];
                Console.WriteLine("ilość nieparzysta znaków - " + result);
                return result;
            }
        }

        public override int CountOccurences(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            throw new System.NotImplementedException();
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            throw new System.NotImplementedException();
        }
    }
}