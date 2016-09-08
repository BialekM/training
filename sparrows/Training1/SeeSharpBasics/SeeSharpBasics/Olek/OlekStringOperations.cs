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
            //throw new System.NotImplementedException();
            /*
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == a)
                {
                    Console.WriteLine(candidate[1]+candidate[2]+candidate[3]);
                }
                return +=;
            }
            */
            string result = "";
            for (int i = start; i < candidate.Length && i = candidate.Length ; i++)
            {
                return 
            }



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