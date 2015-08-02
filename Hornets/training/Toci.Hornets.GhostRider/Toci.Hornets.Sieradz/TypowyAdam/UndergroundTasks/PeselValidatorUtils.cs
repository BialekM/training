﻿using System;
using System.Linq;

namespace Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks
{
    public static class PeselValidatorUtils
    {
        public static readonly int[] monthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        public static readonly int[] vages = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        public static readonly int[] monthSub = { 0, 20, 40, 60, 80 };
        public static readonly int[] yearAdd = { 1900, 2000, 2100, 2200, 1800 };
        public static bool IsDayValid(int year, int month, int day)
        {
            int[] monthDays = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (day <= monthDays[month - 1] && day > 0)
                return true;
            if (month == 2 && IsLeapYear(year) && day == 29)
                return true;
            return false;
        }

        private static bool IsLeapYear(int year)
        {
            return (year%4 == 0 && (year%100 != 0) || (year%400 == 0));

        }
        public static bool monthYearValid(ref int year, ref int month)
        {
            var index = month / 10 / 2;
            year += yearAdd[index];
            month -= monthSub[index];
            return month <= 12 && month >= 1;
        }

        public static bool CheckCheckSum(string pesel)
        {
            int checkSum = 0;
            int[] vages = {1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
            for (int i = 0; i < vages.Length; i++)
            {
                checkSum += (vages[i]*((int)Char.GetNumericValue(pesel[i])));
            }
            if (checkSum%10 != 0)
            {
                if ((10 - checkSum%10) == ((int)Char.GetNumericValue(pesel.Last()))) return true;
                return false;
            }
            if (checkSum%10 == 0 && ((int)Char.GetNumericValue(pesel.Last())) == 0) return true;
            return false;
        }
    }
}