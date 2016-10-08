using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SeeSharpBasics.MagdaSkalik.HashMaps
{
    public class HashMapsExample
    {
        public void HashMapTest()
        {
            Hashtable hash = new Hashtable();

            hash.Add("Magda", "123456789");

        }

        public Hashtable GetCharactersCount(string candidate)
        {
            Hashtable result = new Hashtable();

            for (int i = 0; i < candidate.Length; i++)
            {
                if (result.ContainsKey(candidate[i]))
                {
                    result[candidate[i]] = ((int)result[candidate[i]]) + 1;
                }
                else
                {
                    result.Add(candidate[i], 1);
                }
            }
            return result;
        }
    }
}
