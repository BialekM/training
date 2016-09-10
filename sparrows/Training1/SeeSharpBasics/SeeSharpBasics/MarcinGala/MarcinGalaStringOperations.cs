using System;
using SeeSharpBasics.BartekZapart;

namespace SeeSharpBasics.MarcinGala
{
    public class MarcinGalaStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = 0; i < candidate.Length; i++)
            {
                if (i >= start && i <= length)
                {
                    result = result + candidate[i];
                }
            }
            //MessageBox.Show(result);
            return result;
        }

        public override string GetName()
        {
            string Name = "Marcin Gała";
            //MessageBox.Show(Name);
            return Name;
        }

        public override string GlueBeginingEnd(string candidate)
        {
            char[] charCandidate = candidate.ToCharArray();
            Array.Reverse(charCandidate);
            string output = new string(charCandidate);
            //MessageBox.Show(output + " Wiem że nie do końca o to chodziło ;-)");
            return output + "Wiem że nie do końca o to chodziło ;-)";

            // próby
            /*string result = "";
                   if (charCandidate.Length % 2 == 0)
                   {
                       for (int i = 0; i < charCandidate.Length / 2 ; i++)
                       {
                           result = result + charCandidate[i];
                           for (int j = charCandidate.Length; j > charCandidate.Length / 2; j--)
                           {
                               result = result + charCandidate[i];
                           }
                       }
                   }
                   else
                   {
                       
                   }
       
                   return result; */
        }

        public override int CountOccurences(string candidate, char needle)
        {
            int howMuch = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    howMuch += 1;
                }
            }
            //MessageBox.Show(howMuch.ToString());
            return howMuch;
        }

        public override int LetterPositionInString(string candidate, char needle)
        {
            //string str = candidate;
            //char toFind = needle;
            //int index = str.IndexOf(toFind);
            // MessageBox.Show(index.ToString());
            // return index;
            int pos = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    pos = i;
                    break;
                }
            }
            //MessageBox.Show(pos.ToString());
            return pos;
        }

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            char a = needle;
            char b = replace;
            string newText = candidate;
            newText = newText.Replace(a, b);
            //MessageBox.Show(newText);
            return newText;
        }

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string a = needle;
            string b = replace;
            string newText = candidate;
            newText = newText.Replace(a, b);
            //MessageBox.Show(newText);
            return newText;
        }
    }
}