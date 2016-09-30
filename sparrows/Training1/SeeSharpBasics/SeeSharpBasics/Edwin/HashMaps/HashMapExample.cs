using System.Collections;

namespace SeeSharpBasics.Edwin.HashMaps
{
    public class HashMapExample
    {
        public void HashMapTest()
        {
            Hashtable hashT = new Hashtable();
            //dodawanie do hashtable
            hashT.Add("Edwin", "133");
            hashT.Add("Marian", "521");
        }

        public Hashtable GetCharacterCount(string candidate)
        {
            Hashtable result = new Hashtable();
            for (int i = 0; i < candidate.Length; i++)
            {
                if (result.ContainsKey(candidate[i]))
                {
                    result[candidate[i]] = (int)result[candidate[i]] + 1;
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