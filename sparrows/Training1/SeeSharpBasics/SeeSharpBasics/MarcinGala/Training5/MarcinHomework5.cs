using System;
using SeeSharpBasics.Training5;

namespace SeeSharpBasics.MarcinGala.Training5
{
    public class MarcinHomework5 : Homework
    {
        public override string StringReverse(string candidate)
        {
            string result = "";

            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result += candidate[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
            return result;

        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";

            for (int i = 0; i < candidate.Length; i++)
            {
                if (i == start)
                {

                    for (int j = start; j < start + length && j <= candidate.Length; j++)
                    {
                        result += candidate[j];
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
            return result;
        }
    }
}