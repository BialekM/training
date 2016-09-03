using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurFirstTraining
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Console.ReadLine();

            /*
            Console.WriteLine("Nasz pierwszy program \n");
            Console.WriteLine("nowa linia \n");

            string[] tablicaImion = new string[10];

            tablicaImion[0] = "Adrian";
            tablicaImion[1] = "Arkadiusz";
            tablicaImion[2] = "Błażej";
            tablicaImion[3] = "beatka";
            tablicaImion[8] = "bartek";

            //....
            tablicaImion[9] = "Grzegorz";

            int index = FindIndexInTable(tablicaImion, "bartek"); // 3

            Console.WriteLine("index =  " + index);

            for (int i = 0; i < tablicaImion.Length; i++)
            {
                //tablicaImion[i] = "beatka";
                //Console.WriteLine("imiona z tablicy imion, imie nr  " + i + ": " + tablicaImion[i]);
                
            }

            string Name = "beatka i bartek"; // dlugosc = 15
            int stringLength = Name.Length;
            double zmiennoprzecinkowa = 2.5;
            long dlugiint64b = 4;

            //for (inicjalizacja zmiennych; warunek zakonczenia petli; operacje po kazdej petli)
            for(int i = 0; i < Name.Length; i++)  // dla i 15 petla przerywa dzialanie
            {
               // Console.WriteLine("i = " + i + " znaczek dla i w name = " + Name[i]);
            }

            Console.WriteLine("\n\n");
                  // 14
            for (int i = Name.Length - 1; i >= 0; i--) // i-- = i - 1
            {
               // Console.WriteLine("i = " + i + " znaczek dla i w name = " + Name[i]);
                //Console.Write(Name[i]); // ket...
            }
            //Console.WriteLine(Name.Reverse());

            string reversed = ReverseString(Name);
            string reversedTest = ReverseString("text testowy");

            Console.WriteLine("\n Odwrocony: " + reversed);
            Console.WriteLine("\n Odwrocony: " + reversedTest);

            //Console.WriteLine("\n substring: " + Substring("beatka", 2, 4));
            //Console.WriteLine("\n substring: " + Substring("bartloemij", 2, 4));


            // operatoery : + - * / ^ | &
            if ((stringLength > 10 && stringLength < 20) || stringLength == 21) // > < >= <= != == || && jesli jest miezdy 11 i 19
            {
                //Console.WriteLine("\n dlugosc stringu: " + stringLength);

                Console.ReadLine();
            }
            else if(stringLength == 22)
            {
                Console.ReadLine();
            }
            else
            {
                Console.ReadLine();
            }
            */
        }

        public static int FindIndexInTable(string[] table, string value)
        {
            // przechdozi cala tablice i podaje index textu value dla ktrorego table[i] == value

            for (int i = 0; i < table.Length; i++)
            {
                if (table[i] == value) // dla 0 Adrian == beatka ?, dla 1 Arkadiusz == beatka
                {
                    return i;
                }
            }

            return -1;
        }

        public static string ReverseString(string candidate)
        {
            string result = "";

            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result = result + candidate[i];
            }

            //Console.WriteLine("reverse string result drukowanie z metody ReverseString: " + result);

            return result;
        }

        public static bool IsPalindrom(string candidate)
        {
            // kajak
            string reversedString = ReverseString(candidate);

            return reversedString == candidate; // kajak == kajak
        }

        public static string Substring(string candidate, int start, int length)
        {
            string fragment = "";

            for (int i = start; i < start + length; i++)
            {
                fragment += candidate[i];
            }

            return fragment;
        }

        public static string ReplaceInText(string candidate, string find, string replace)
        {
            // beata, at, atk => beatka
            for (int i = 0; i < candidate.Length; i++)
            {
                string sub = Substring(candidate, i, find.Length); // be ea at ta
            }

            //return 
            return null;
        }

        public static void MetodaSpaghetti()
        {
            if (true)
            {
                if (true)
                {
                    for (;;)
                    {
                        
                    }
                }
                else
                {
                    if (true)
                    {
                        int zmienna = 5;
                        int zmienna2 = 5;
                    }

                    if (true)
                    {
                        if (true)
                        {
                            for (; ; )
                            {

                            }
                        }
                        else
                        {
                            if (true)
                            {
                                int zmienna = 5;
                                int zmienna2 = 5;
                            }

                            if (true)
                            {
                                if (true)
                                {
                                    for (; ; )
                                    {

                                    }
                                }
                                else
                                {
                                    if (true)
                                    {
                                        int zmienna = 5;
                                        int zmienna2 = 5;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //nsapiasc funckcje ktora odwroci text
    }
}
