using SeeSharpBasics.Training5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharpBasics.SoniaKozubik
{
    public class SoniaKozubikHomework:Homework
    {
        public override string StringReverse(string candidate)
        {
            string result = "";
            for (int i = candidate.Length - 1; i >= 0; i--)
            {
                result += candidate[i];
            }
            return result;
        }

        public override string Substring(string candidate, int start, int length)
        {
            string result = "";
            for (int i = start; i < start + length; i++)
            {
                result += candidate[i];
            }
            return result;
        }
    }
}
