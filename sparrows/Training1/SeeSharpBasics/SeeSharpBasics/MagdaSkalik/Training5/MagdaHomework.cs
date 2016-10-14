using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeeSharpBasics.Training5;


namespace SeeSharpBasics.MagdaSkalik.Training5
{
    public class MagdaHomework:Homework
    {
        public override string StringReverse(string candidate)
        {
            return base.StringReverse(candidate);
        }

        public override string Substring(string candidate, int start, int length)
        {
            string fragment = "";
            for (int i = start; i < (start + length) && i < candidate.Length; i++)

            {
                fragment += candidate[i];
            }
            return fragment;
        }
    }
}
