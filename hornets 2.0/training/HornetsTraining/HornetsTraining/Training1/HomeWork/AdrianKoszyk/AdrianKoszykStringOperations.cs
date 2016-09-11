using System;
using System.Collections.Specialized;
using System.Linq.Expressions;

namespace HornetsTraining.Training1.HomeWork.AdrianKoszyk
{
    public class AdrianKoszykStringOperations : StringOperations
    {
        public override string GetName()
        {
            return "Adrian Koszyk";
        }

        public override string Substring(string candidate, int start, int length)
        {
            string Words = "";
            for (int i = start; i < start + length; i++)
            {
                Words += candidate[i];
            }
            return Words;
        }

        public override int PositionInString(string candidate, string needle)
        {
            int sizeNeedle = needle.Length;
            string[] ArrayWord = cutWord(candidate, sizeNeedle);

            for (int i = 0; i < ArrayWord.Length; i++)
            {
                if (ArrayWord[i] == needle)
                    return i;

            }
            return -1;
        }


        public override string StringReplace(string candidate, string needle, string replaceWith)
        {
            int index = PositionInString(candidate, needle);
            string newWord = "";
            string endWord = "";

            for (int i = 0; i < index; i++)
                newWord += candidate[i];

            newWord += replaceWith;

            for (int i = index + needle.Length; i < candidate.Length; i++)
                endWord += candidate[i];

            newWord += endWord;

            return newWord;
        }

        // Funkcje pomocnicze
        public string[] cutWord(string candidate, int sizeNeeetle)
        {
            int zmienna = candidate.Length - sizeNeeetle;
            string[] tab = new string[zmienna + 1];

            for (int i = 0; i <= zmienna; i++)
                for (int j = i; j < i + sizeNeeetle; j++)
                    tab[i] += candidate[j];

            return tab;
        }
    }
}