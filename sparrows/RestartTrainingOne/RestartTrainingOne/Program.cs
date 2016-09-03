using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestartTrainingOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaCalkowita = 5;
            double liczbaZmiennoprzecinkowa = 4.55d;
            float tezZmiennoprzecinkowa = 4.674587485647386783678735867586f;
            bool zmiennalogiczna = true;
            string imie = "bartek";
            char znaczek = 'b';
            char[] tablica = new[] {'b', 'a', 'r', 't', 'e', 'k', ' ', 'i', ' ', 'b','e','a','t','a'};

            int bezwartosci;

            bezwartosci = 8; // porownaie : ==

            if (bezwartosci <= 8 && bezwartosci >= 16) // 9 - 15 psikus dla pozostalych liczba z bezwartosci
            {
                Console.WriteLine(bezwartosci);
            }
            else
            {
                Console.WriteLine("psikus");
            }

            Console.WriteLine("dlugosc tablicy znakow: " + tablica.Length);

            string result = "";
            //obracanie
            for (int j = imie.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(imie[j]);
            }

            for (var i = 0; i < tablica.Length; i++)
            {
                result += tablica[i];
            }

            Console.WriteLine("sklejona tablica znakow: " + result);

            Console.ReadLine();
        }
    }
}
