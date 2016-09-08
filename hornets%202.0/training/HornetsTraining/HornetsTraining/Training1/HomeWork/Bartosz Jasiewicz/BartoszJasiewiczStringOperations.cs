using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class BartoszJasiewiczStringOperations : StringOperations
    {
        public string userName;
        public int positionInString = 0;
        public string extract;
        public string finalString = "";
        //podanie imienia
        public override string GetName()
        {
            Console.Write("Podaj imie: ");
            userName = Console.ReadLine();
            Console.Write("Podaj fragment do wyciecia: ");
            extract = Console.ReadLine();
            return extract;
        }
        public override string StringReplace(string candidate, string needle, string replacedWith)
        {
            string listOfCharsInSubstring = "";
            string finalString = "";
            int positionInString = PositionInString(candidate, needle);
            Console.WriteLine(positionInString);
            for (int i = 0; i < candidate.Length; i++)
            {
                listOfCharsInSubstring += candidate[i];
                if (i == positionInString - 1)
                {
                    finalString = listOfCharsInSubstring + replacedWith;
                }
            }
            for (int i = positionInString + needle.Length; i < candidate.Length; i++)
            {
                finalString += candidate[i];
            }
            return finalString;
        }

        //zwraca wycinek stringu od start do dlugosci length: beatka, 1, 3=> eat
        public override string Substring(string candidate, int start, int length)
        {
            //start = PositionInString(userName, extract); //null reference exception
            string subExtract = "";
            for (int i = start; i < length + start; i++)
            {
                subExtract += candidate[i];

                if (start + length > candidate.Length)
                {
                    return "ERROR\nChcesz wyciac poza tablica";
                }
            }
            return subExtract;
        }

        //public override RemoveInString(string candidate,)

        //pozycja stringu w stringu
        public override int PositionInString(string candidate, string needle)
        {
            for (int i = 0; i < candidate.Length; i++)
            {

                if (candidate[i] == needle[positionInString])
                {
                    return i;
                }

            }
            return 1;
        }


    }
}

