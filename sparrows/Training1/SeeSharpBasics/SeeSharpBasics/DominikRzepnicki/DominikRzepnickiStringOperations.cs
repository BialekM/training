using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.DominikRzepnicki
{
    public class DominikRzepnickiStringOperations : StringOperations
    {
        private string result;

        public override int CountOccurences(string candidate, char needle) //bartek, a =>1; beatka, a=>2; aaaaba, a =>5
        {
            int counter = 0;

            for (int i = 0; i < candidate.Length; i++)
            {
                //Console.Write(candidate[i]);  //wyświetlenie imienia Bartek

                if (candidate[i] == needle)  // needle = a, zadeklarowano to w programie; == jest to sprawdzenie czy cos sie rowna
                {
                    counter += 1;
                    //Console.Write(counter);
                }
            }

            return counter;
        }

        public override string GetName()
        {
            return "Dominik Rzepnicki";
        }

        public override string GlueBeginingEnd(string candidate)
        {
            for (int i = 0, j = candidate.Length - 1; i < j; i++, j--) //beata => baeta
            {
                result += candidate[i];
                result += candidate[j];
            }

            Console.WriteLine(result);

            return "";
        }

        public override int LetterPositionInString(string candidate, char needle)   //bartek, k => 5
        {
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                    return i;
            }

            return -1;
        }

        public override string LetterReplace(string candidate, char needle, char replace) //beatka, e, s => bsatka; beatka, a, b => bebtkb (podmienia a na b)
        {
            Console.WriteLine(candidate);
            result = "";

            for (int i = 0; i < candidate.Length; i++) // b e s, e e s
            {
                if (candidate[i] == needle)  // needle = a, zadeklarowano to w programie; == jest to sprawdzenie czy cos sie rowna
                {
                    result += replace;  //zastepuje ta prawidlowa jezeli w wyrazie jest 'e'
                }
                else
                {
                    result += candidate[i]; //ignoruje i dalej wypisuje ten wyraz (ale musi go tez dodawac)

                }
            }

            return result;
        }

        public override string StringReplace(string candidate, string needle, string replace)   //bartlomiej, art, beatka => bbeatkalomiej 
        {
            result = "";
            Console.WriteLine(candidate);
            int index = -1; // zwykly index = 0, gdybym nie dal = to zainicjowaloby sie na 0; w tej zmiennej bedzie liczba, która odnajdziemy w stringu''

            //int aa = candidate.IndexOf(needle);  //indexOf sprawdza czy dany ciag liter istnieje w candidate
            for (int i = 0; i < candidate.Length - needle.Length; i++)  //pierwsza petla - badam B - nie pasuje ide dalej
            {
                for (int j = 0; j < needle.Length; j++)  //sprawdza tylko 3 litery (ciag 'art')
                {
                    if (candidate[j + i] != needle[j]) // gdy znak nie bedzie sie zgadzal 'art' to wyrzuca break'a
                    {
                        break;
                    }

                    if (j == needle.Length - 1)
                    {
                        index = i;  //zapisuje index 1, bo tutaj zaczyna sie ciag, ktory chcemy zastapic
                    }
                }
            }

            //wypisujemy Beatka zastepujac ciag 'art'
            for (int i = 0; i < candidate.Length; i++)
            {
                //jezeli nie jest to ten index to nie zastepujemy niczym - dalej idzie Bartlomiej
                if (i != index)
                {
                    result += candidate[i]; //do 
                }
                else
                {
                    result += replace;  //jezeli index = 1, to idzie na 4 miejsce indexu i kontynuuje wyraz barltomiej
                    i += needle.Length;
                }
            }

            return result;
        }

        public override string Substring(string candidate, int start, int length)
        {
            result = "";    //z kazdym wejsciem do metody wartosci ustawiane sa od '0'

            //return base.Substring(candidate, start, length);
            for (int i = start; i < start + length; i++)    // i = start; i < length; i++ (Przy string'u Bartek, warunku start=2, koniec=4, wyświetli się 'rt')
            {
                Console.Write(candidate[i]);  // wyswielta w konsoli aktaeB

                result += candidate[i];  // bo sklejamy do string'a wynikowego poszczegolne litery; result += candidate[i] <=> result = result + candidate[i]
            }

            //Console.ReadKey();
            return result;
        }
    }
}
