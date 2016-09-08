using System;

namespace SeeSharpBasics.Olek
{
    public class OlekStringOperations : StringOperations

    {
        // Substring
       
        /*public int a = 1;
        public int b = 3;
        public int c = 2;
        public int d = 3;
       
        Substring(string beatka, int a, int b); //beatka - eat (1,2,3)
        Substring(string bartek, int c, int d);
        */

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            //Substring("beatka", 1, 3); eat
            //Substring("bartek", 2, 4); rtek

            //for (int i = start; i < ((candidate.Length - length)+1); i++)
            for (int i = start; i < (candidate.Length - (candidate.Length-length))+1; i++)
            {
                result = candidate[i].ToString();
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
            throw new System.NotImplementedException();
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