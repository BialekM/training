using System;
using SeeSharpBasics.Training3.Homework;

namespace SeeSharpBasics.MarcinGala.Training3
{
    public class MarcinPeselValidator : PeselValidator
    {

        public string Year = "";
        public string Month = "";
        public string Date = "";

        public override bool IsPeselValid(string peselCandidate)
        {
            if (peselCandidate.Length != 11)
            {
                Console.WriteLine("Pesel musi składać się z 11 cyfr!");
                Console.ReadKey();
                return false;
            }

            Year = peselCandidate.Substring(0, 2);
            Month = peselCandidate.Substring(2, 2);
            Date = peselCandidate.Substring(0, 5);

            if (IsPeselDateValid(Year, Month, Date) == false)
            {
                Console.WriteLine("Twoj pesel jest nieprawidlowy");
                Console.ReadKey();
                return false;
            }

            // Suma kontrolna i sprawdzenie poprawności numeru
            string numberControl = peselCandidate.Substring(10, 1);
            int numberControlToInt = int.Parse(numberControl);
            //1
            string numberPesel1 = peselCandidate.Substring(0, 1);
            int numberPesel1ToInt = int.Parse(numberPesel1);
            //2
            string numberPesel2 = peselCandidate.Substring(1, 1);
            int numberPesel2ToInt = int.Parse(numberPesel2);
            //3
            string numberPesel3 = peselCandidate.Substring(2, 1);
            int numberPesel3ToInt = int.Parse(numberPesel3);
            //4
            string numberPesel4 = peselCandidate.Substring(3, 1);
            int numberPesel4ToInt = int.Parse(numberPesel4);
            //5
            string numberPesel5 = peselCandidate.Substring(4, 1);
            int numberPesel5ToInt = int.Parse(numberPesel5);
            //6
            string numberPesel6 = peselCandidate.Substring(5, 1);
            int numberPesel6ToInt = int.Parse(numberPesel6);
            //7
            string numberPesel7 = peselCandidate.Substring(6, 1);
            int numberPesel7ToInt = int.Parse(numberPesel7);
            //8
            string numberPesel8 = peselCandidate.Substring(7, 1);
            int numberPesel8ToInt = int.Parse(numberPesel8);
            //9
            string numberPesel9 = peselCandidate.Substring(8, 1);
            int numberPesel9ToInt = int.Parse(numberPesel9);
            //9
            string numberPesel10 = peselCandidate.Substring(9, 1);
            int numberPesel10ToInt = int.Parse(numberPesel10);

            int sumControl = 1 * numberPesel1ToInt + 3 * numberPesel2ToInt + 7 * numberPesel3ToInt + 9 * numberPesel4ToInt + 1 * numberPesel5ToInt + 3 * numberPesel6ToInt + 7 * numberPesel7ToInt + 9 * numberPesel8ToInt + 1 * numberPesel9ToInt + 3 * numberPesel10ToInt;
            int toCompare;


            if (sumControl % 10 == 0)
            {
                toCompare = 0;
            }
            else
            {
                toCompare = 10 - (sumControl % 10);
            }

            if (numberControlToInt == toCompare)
            {
                Console.WriteLine("Hurra twoj pesel jest prawidlowy:-)");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("Buu Twoj pesel nie jest prawidlowy:-(");
                Console.ReadKey();
                return false;
            }
        }

        protected override bool IsPeselDateValid(string year, string month, string day)
        {
            int yearToInt = int.Parse(year);
            int monthToInt = int.Parse(month);


            if (yearToInt >= 81 && yearToInt <= 92 || yearToInt >= 01 && yearToInt <= 12 || yearToInt >= 21 && yearToInt <= 32 || yearToInt >= 41 && yearToInt <= 52 || yearToInt >= 61 && yearToInt <= 72)
            {
                if (monthToInt >= 01 && monthToInt <= 12)
                {
                    if (day.Length == 5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
    
