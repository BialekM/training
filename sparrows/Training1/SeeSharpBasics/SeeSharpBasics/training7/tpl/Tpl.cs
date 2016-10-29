using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace SeeSharpBasics.training7.tpl
{
    public class TplExample
    {
        public Dictionary<string, int>  dlugosci = new Dictionary<string, int>();

        public void TplAsParalelShowDown()
        {
            List<string> lista = new List<string>
            {
                "Edwin", "konrad", "marcin", "andrzej", "slawek",
                "andrzej1", "Edwin2", "konrad3", "marcin4", "olek5", "slawek6", "olek"
                
                
            };

            Stopwatch st = new Stopwatch();

            st.Start();

            lista.AsParallel().WithDegreeOfParallelism(3).ForAll(Del);

            st.Stop();
            //st.Elapsed;
        }

        private void Del(string element)
        {
            if (element.Length == 4)
            {
                //Thread.Sleep(1111);
                throw new Exception();
            }

            dlugosci.Add(element, element.Length);
        }
    }
}