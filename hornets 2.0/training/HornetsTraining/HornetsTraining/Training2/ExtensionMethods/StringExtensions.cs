using System;
using System.Collections;
using System.Collections.Generic;

namespace Toci.HornetsTraining.Training2.ExtensionMethods
{
    public static class StringExtensions
    {
        public static bool IsPalindrome(this string obj, bool checkWhatever)
        {
            return true;
        }


        public static bool Whatever(this IDisposable obj)
        {
            return true;
        }

        public static bool Check<T>(this IEnumerable<T> obj)
        {
            return true;
        }

        public static T IAmExtensive<T>(this T obj) where T : IEnumerable
        {
            return default(T);
        }

        public static string GetBankId(this string text)
        {
            return text.Substring(2, 4);
        }
    }
}