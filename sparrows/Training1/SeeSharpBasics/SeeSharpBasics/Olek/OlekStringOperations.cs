﻿using System;

namespace SeeSharpBasics.Olek
{
    public class OlekStringOperations : StringOperations

    {
        //public override string Substring(string candidate, int start, int length)
        //{
        //    //throw new System.NotImplementedException();
        //    string result = "";

        //    //Substring("beatka", 1, 3); eat
        //    //Substring("bartek", 2, 4); rtek
        //    //Substring("aleksander", 5, 2);  an
        //    for (int i = start; i < start + length; i++)
        //    {
        //        result += candidate[i].ToString();
        //        Console.Write(result);
        //    }
        //    return result;
        //}

        public override string Substring(string candidate, int start, int length)   // beatka, 1, 3 => eat ; bartek, 2, 4 => rtek
        {
            string result = "";

            if (start >= candidate.Length - 1)
            {
                Console.Write("Przekroczony zakres stringu. \nDługość stringu = {0}.\n" +
                              "Podaj mniejszą wartość niż {0}", candidate.Length - 1);
            }
            else
                if (length >= candidate.Length - 1)
                {
                    Console.WriteLine("za duża wartość wyświtelania zanaków\nprogram odczyta i tak tylko tyle, ile indekśów ma string ({0}) i nie więcej.\nMaksymalna wartość drugiego parametru: {1}\n", candidate.Length, candidate.Length - 1);
                }
            for (int i = start; i <= (start + length) - 1 && i < candidate.Length; i++)
            {
                result += candidate[i].ToString();
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
            if (candidate.Contains(needle.ToString()))
                {
                    for (int i = 0; i < candidate.Length; i++)
                    {
                        if (candidate[i] == needle)
                        {
                            var result = i + 1;
                            Console.Write("Znak '{0}' znajduje się na {1} miejscu w stringu '{2}.", needle, result,
                                candidate);
                            break;
                        }
                    }
                }
                else
                {
                    Console.Write("Nie ma znaku '{0}' w stringu '{1}'.",needle, candidate);
                }
            return 0; // system zaproponował....
        }


            //{
            //    for (int i = 0; i < candidate.Length; i++)
            //    {
            //        if (candidate[i] == needle)
            //        {
            //            var result = i + 1;
            //            Console.Write("Znak '{0}' znajduje się na {1} miejscu w stringu '{2}.", needle, result,
            //                candidate);
            //            return;
            //        }
            //    }
            //    Console.Write("Nie ma znaku '{0}' w stringu '{1}'.", needle, candidate);
            //}

        //}

        public override int LetterPositionInString(string candidate, char needle)
        {
            throw new System.NotImplementedException();
        }

        // Letter......2 bez ołwerrajdowania ;)
        // zamiast int zrobiłem string, ale dałem "int result" i później
        // na końcu zwracam result.ToString i bangla :)
        //  klasa, w której umieściłem kod nazywa się "Opracowana", więc w "Program.cs"
        //  umiesczam to, co poniżej zakomentowane:
        //{
        //    Opracowana xyz = new Opracowana(); //wystąpienie-instancja klasy nazwane xyz
        //    xyz.LetterPositionInString("Kapsel", 'p'); //imię mojego psa ;)
        //}
        public string LetterPositionInString2(string candidate, char needle)
        {
            int result = 0;
            for (int i = 0; i < candidate.Length; i++)
            {
                if (candidate[i] == needle)
                {
                    result = i + 1; //nie liczę znaków w wyrazie od zera, 
                                    //tylko tak, jak przeciętny człowiek
                }
            }
            Console.WriteLine("literka \"{0}\" w wyrazie {1} jest na miejscu {2}"
                                        , needle, candidate, result);
            Console.ReadKey();
            return result.ToString();
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