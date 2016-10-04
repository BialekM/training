using System;
using SeeSharpBasics.BartekZapart;
namespace SeeSharpBasics.MagdaSkalik
{
    public class MagdaSkalikStringOperations : StringOperations
    {
        public override string Substring(string candidate, int start, int length)
        {
            string fragment = "";
            for(int i = start; i< (start+length) && i< candidate.Length;i++)

            {
                fragment+=candidate[i];
            }
            return fragment;
        }// beatka, 1, 3 => eat ; bartek, 2, 4 => rtek

        public override string GetName()
        {
            return "Magda Skalik";
        }// zwrocic swoje imie i nazwisko

        public override string GlueBeginingEnd(string candidate)
        {
            string result = "";
            int candLen = candidate.Length;
            for (int i = 0; i < candLen / 2; i++)
            {
                result = result + candidate[i] + candidate[candLen - 1 - i];
            }
                if (candLen % 2 == 0)
                {
                    return result;
                }
                else
                {
                    result = result + candidate[(candidate.Length / 2)];
                    return result;
                }

        }

        public override int CountOccurences(string candidate, char needle)
        {
            int account = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    account++;
                }
            }
            return account;
        }// bartek, a => 1 beatka, a => 2, aaaaba, a => 5

        public override int LetterPositionInString(string candidate, char needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if(candidate[i]==needle)
                {
                    return i;
                }
            }
            return 0;
        }// bartek, k => 5

        public override string LetterReplace(string candidate, char needle, char replace)
        {
            string result = "";
            for (int i = 0; i < candidate.Length;i++)
            {
                if(candidate[i] == needle)
                {
                    result += replace;
                    i++;
                }
                else
                {
                    result += candidate[i];
                }

            }
            return "result";
        }// beatka, e, s => bsatka ; beatka , a , b => bebtkb

        public override string StringReplace(string candidate, string needle, string replace)
        {
            string text = "";
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {

                text = Substring(candidate, i, needle.Length);

                if (text == needle)
                {

                        result += replace;
                        i = i + needle.Length - 1;

                }
                else
                {
                    result += candidate[i];
                }
            }
            return result;
             }// bartlomiej, art, beatka => bbeatkalomiej

        public void Magda(string a)
        {

        }

        //public static string ReplaceInText(string candidate, string find, string replace)
        //{
        //    string text = "";
        //    string result = "";

        //    for (int i = 0; i < candidate.Length; i++)
        //    {

        //        text = Substring(candidate, i, find.Length);

        //        if (text == find)
        //        {

        //            result += replace;
        //            i = i + find.Length - 1;

        //        }
        //        else
        //        {
        //            result += candidate[i];
        //        }
        //    }
        //    return result;
        //}
    }
}
